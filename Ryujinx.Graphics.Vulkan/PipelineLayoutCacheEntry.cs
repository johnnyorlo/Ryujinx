using Ryujinx.Graphics.GAL;
using Silk.NET.Vulkan;
using System;
using System.Collections.Generic;

namespace Ryujinx.Graphics.Vulkan
{
    class PipelineLayoutCacheEntry
    {
        private const uint DescriptorPoolMultiplier = 4;
        private const int MaxPoolSizesPerSet = 3;

        private readonly VulkanRenderer _gd;
        private readonly Device _device;

        public DescriptorSetLayout[] DescriptorSetLayouts { get; }
        public PipelineLayout PipelineLayout { get; }

        private readonly List<Auto<DescriptorSetCollection>>[][] _dsCache;
        private readonly int[] _dsCacheCursor;
        private int _dsLastCbIndex;

        private readonly uint _bindlessTexturesCount;
        private readonly uint _bindlessSamplersCount;

        private PipelineLayoutCacheEntry(VulkanRenderer gd, Device device)
        {
            _gd = gd;
            _device = device;

            _dsCache = new List<Auto<DescriptorSetCollection>>[CommandBufferPool.MaxCommandBuffers][];

            for (int i = 0; i < CommandBufferPool.MaxCommandBuffers; i++)
            {
                _dsCache[i] = new List<Auto<DescriptorSetCollection>>[PipelineBase.DescriptorSetLayoutsBindless];

                for (int j = 0; j < PipelineBase.DescriptorSetLayoutsBindless; j++)
                {
                    _dsCache[i][j] = new List<Auto<DescriptorSetCollection>>();
                }
            }

            _dsCacheCursor = new int[PipelineBase.DescriptorSetLayoutsBindless];
        }

        public PipelineLayoutCacheEntry(VulkanRenderer gd, Device device, PipelineLayoutUsageInfo usageInfo) : this(gd, device)
        {
            DescriptorSetLayouts = PipelineLayoutFactory.Create(gd, device, usageInfo, out var pipelineLayout);
            PipelineLayout = pipelineLayout;
            _bindlessTexturesCount = usageInfo.BindlessTexturesCount;
            _bindlessSamplersCount = usageInfo.BindlessSamplersCount;
        }

        public PipelineLayoutCacheEntry(VulkanRenderer gd, Device device, ShaderSource[] shaders) : this(gd, device)
        {
            DescriptorSetLayouts = PipelineLayoutFactory.CreateMinimal(gd, device, shaders, out var pipelineLayout);
            PipelineLayout = pipelineLayout;
            _bindlessTexturesCount = 0;
            _bindlessSamplersCount = 0;
        }

        public Auto<DescriptorSetCollection> GetNewDescriptorSetCollection(
            VulkanRenderer gd,
            int commandBufferIndex,
            int setIndex,
            out bool isNew)
        {
            if (_dsLastCbIndex != commandBufferIndex)
            {
                _dsLastCbIndex = commandBufferIndex;

                for (int i = 0; i < PipelineBase.DescriptorSetLayoutsBindless; i++)
                {
                    _dsCacheCursor[i] = 0;
                }
            }

            var list = _dsCache[commandBufferIndex][setIndex];
            int index = _dsCacheCursor[setIndex]++;
            if (index == list.Count)
            {
                Span<DescriptorPoolSize> poolSizes = stackalloc DescriptorPoolSize[MaxPoolSizesPerSet];
                poolSizes = GetDescriptorPoolSizes(poolSizes, setIndex);

                // All bindless resources have the update after bind flag set,
                // this is required for Intel, otherwise it just crashes when binding the descriptor sets
                // for bindless resources (maybe because it is above the limit?)
                bool updateAfterBind = setIndex >= PipelineBase.BindlessBufferTextureSetIndex;

                var dsc = gd.DescriptorSetManager.AllocateDescriptorSet(gd.Api, DescriptorSetLayouts[setIndex], poolSizes, updateAfterBind);
                list.Add(dsc);
                isNew = true;
                return dsc;
            }

            isNew = false;
            return list[index];
        }

        private Span<DescriptorPoolSize> GetDescriptorPoolSizes(Span<DescriptorPoolSize> output, int setIndex)
        {
            uint multiplier = DescriptorPoolMultiplier;
            int count = 1;

            switch (setIndex)
            {
                case PipelineBase.UniformSetIndex:
                    output[0] = new DescriptorPoolSize(DescriptorType.UniformBuffer, (1 + Constants.MaxUniformBufferBindings) * multiplier);
                    break;
                case PipelineBase.StorageSetIndex:
                    output[0] = new DescriptorPoolSize(DescriptorType.StorageBuffer, Constants.MaxStorageBufferBindings * multiplier);
                    break;
                case PipelineBase.TextureSetIndex:
                    output[0] = new DescriptorPoolSize(DescriptorType.CombinedImageSampler, Constants.MaxTextureBindings * multiplier);
                    output[1] = new DescriptorPoolSize(DescriptorType.UniformTexelBuffer, Constants.MaxTextureBindings * multiplier);
                    count = 2;
                    break;
                case PipelineBase.ImageSetIndex:
                    output[0] = new DescriptorPoolSize(DescriptorType.StorageImage, Constants.MaxImageBindings * multiplier);
                    output[1] = new DescriptorPoolSize(DescriptorType.StorageTexelBuffer, Constants.MaxImageBindings * multiplier);
                    count = 2;
                    break;
                case PipelineBase.BindlessTexturesSetIndex:
                    output[0] = new DescriptorPoolSize(DescriptorType.UniformBuffer, 1);
                    output[1] = new DescriptorPoolSize(DescriptorType.StorageBuffer, 1);
                    output[2] = new DescriptorPoolSize(DescriptorType.SampledImage, _bindlessTexturesCount);
                    count = 3;
                    break;
                case PipelineBase.BindlessBufferTextureSetIndex:
                    output[0] = new DescriptorPoolSize(DescriptorType.UniformTexelBuffer, _bindlessTexturesCount);
                    break;
                case PipelineBase.BindlessSamplersSetIndex:
                    output[0] = new DescriptorPoolSize(DescriptorType.Sampler, _bindlessSamplersCount);
                    break;
                case PipelineBase.BindlessImagesSetIndex:
                    output[0] = new DescriptorPoolSize(DescriptorType.StorageImage, _bindlessTexturesCount);
                    break;
                case PipelineBase.BindlessBufferImageSetIndex:
                    output[0] = new DescriptorPoolSize(DescriptorType.StorageTexelBuffer, _bindlessTexturesCount);
                    break;
            }

            return output.Slice(0, count);
        }

        protected virtual unsafe void Dispose(bool disposing)
        {
            if (disposing)
            {
                for (int i = 0; i < _dsCache.Length; i++)
                {
                    for (int j = 0; j < _dsCache[i].Length; j++)
                    {
                        for (int k = 0; k < _dsCache[i][j].Count; k++)
                        {
                            _dsCache[i][j][k].Dispose();
                        }

                        _dsCache[i][j].Clear();
                    }
                }

                _gd.Api.DestroyPipelineLayout(_device, PipelineLayout, null);

                for (int i = 0; i < DescriptorSetLayouts.Length; i++)
                {
                    _gd.Api.DestroyDescriptorSetLayout(_device, DescriptorSetLayouts[i], null);
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
