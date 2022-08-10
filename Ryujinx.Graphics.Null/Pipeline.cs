using Ryujinx.Graphics.GAL;
using Ryujinx.Graphics.Shader;

namespace Ryujinx.Graphics.Null
{
    internal class Pipeline : IPipeline
    {
        public void Barrier()
        {
        }

        public void BeginTransformFeedback(PrimitiveTopology topology)
        {
        }

        public void ClearBuffer(BufferHandle destination, int offset, int size, uint value)
        {
        }

        public void ClearRenderTargetColor(int index, int layer, int layerCount, uint componentMask, ColorF color)
        {
        }

        public void ClearRenderTargetDepthStencil(int layer, int layerCount, float depthValue, bool depthMask, int stencilValue, int stencilMask)
        {
        }

        public void CommandBufferBarrier()
        {
        }

        public void CopyBuffer(BufferHandle source, BufferHandle destination, int srcOffset, int dstOffset, int size)
        {
        }

        public void DispatchCompute(int groupsX, int groupsY, int groupsZ)
        {
        }

        public void Draw(int vertexCount, int instanceCount, int firstVertex, int firstInstance)
        {
        }

        public void DrawIndexed(int indexCount, int instanceCount, int firstIndex, int firstVertex, int firstInstance)
        {
        }

        public void DrawTexture(ITexture texture, ISampler sampler, Extents2DF srcRegion, Extents2DF dstRegion)
        {
        }

        public void EndHostConditionalRendering()
        {
        }

        public void EndTransformFeedback()
        {
        }

        public void MultiDrawIndexedIndirectCount(BufferRange indirectBuffer, BufferRange parameterBuffer, int maxDrawCount, int stride)
        {
        }

        public void MultiDrawIndirectCount(BufferRange indirectBuffer, BufferRange parameterBuffer, int maxDrawCount, int stride)
        {
        }

        public void SetAlphaTest(bool enable, float reference, CompareOp op)
        {
        }

        public void SetBlendState(int index, BlendDescriptor blend)
        {
        }

        public void SetDepthBias(PolygonModeMask enables, float factor, float units, float clamp)
        {
        }

        public void SetDepthClamp(bool clamp)
        {
        }

        public void SetDepthMode(DepthMode mode)
        {
        }

        public void SetDepthTest(DepthTestDescriptor depthTest)
        {
        }

        public void SetFaceCulling(bool enable, Face face)
        {
        }

        public void SetFrontFace(FrontFace frontFace)
        {
        }

        public void SetImage(int binding, ITexture texture, Format imageFormat)
        {
        }

        public void SetIndexBuffer(BufferRange buffer, IndexType type)
        {
        }

        public void SetLineParameters(float width, bool smooth)
        {
        }

        public void SetLogicOpState(bool enable, LogicalOp op)
        {
        }

        public void SetMultisampleState(MultisampleDescriptor multisample)
        {
        }

        public void SetPatchParameters(int vertices, ReadOnlySpan<float> defaultOuterLevel, ReadOnlySpan<float> defaultInnerLevel)
        {
        }

        public void SetPointParameters(float size, bool isProgramPointSize, bool enablePointSprite, Origin origin)
        {
        }

        public void SetPolygonMode(PolygonMode frontMode, PolygonMode backMode)
        {
        }

        public void SetPrimitiveRestart(bool enable, int index)
        {
        }

        public void SetPrimitiveTopology(PrimitiveTopology topology)
        {
        }

        public void SetProgram(IProgram program)
        {
        }

        public void SetRasterizerDiscard(bool discard)
        {
        }

        public void SetRenderTargetColorMasks(ReadOnlySpan<uint> componentMask)
        {
        }

        public void SetRenderTargets(ITexture[] colors, ITexture depthStencil)
        {
        }

        public void SetRenderTargetScale(float scale)
        {
        }

        public void SetScissors(ReadOnlySpan<Rectangle<int>> regions)
        {
        }

        public void SetStencilTest(StencilTestDescriptor stencilTest)
        {
        }

        public void SetStorageBuffers(int first, ReadOnlySpan<BufferRange> buffers)
        {
        }

        public void SetTextureAndSampler(ShaderStage stage, int binding, ITexture texture, ISampler sampler)
        {
        }

        public void SetTransformFeedbackBuffers(ReadOnlySpan<BufferRange> buffers)
        {
        }

        public void SetUniformBuffers(int first, ReadOnlySpan<BufferRange> buffers)
        {
        }

        public void SetUserClipDistance(int index, bool enableClip)
        {
        }

        public void SetVertexAttribs(ReadOnlySpan<VertexAttribDescriptor> vertexAttribs)
        {
        }

        public void SetVertexBuffers(ReadOnlySpan<VertexBufferDescriptor> vertexBuffers)
        {
        }

        public void SetViewports(ReadOnlySpan<Viewport> viewports, bool disableTransform)
        {
        }

        public void TextureBarrier()
        {
        }

        public void TextureBarrierTiled()
        {
        }

        public bool TryHostConditionalRendering(ICounterEvent value, ulong compare, bool isEqual)
        {
            return true;
        }

        public bool TryHostConditionalRendering(ICounterEvent value, ICounterEvent compare, bool isEqual)
        {
            return true;
        }

        public void UpdateRenderScale(ReadOnlySpan<float> scales, int totalCount, int fragmentCount)
        {
        }
    }
}
