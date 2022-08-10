using Ryujinx.Common.Configuration;
using Ryujinx.Graphics.GAL;
using Ryujinx.Graphics.Shader.Translation;
using System.Runtime.CompilerServices;

namespace Ryujinx.Graphics.Null
{
    public class NullRenderer : IRenderer
    {
        public bool PreferThreading => true;

        public IPipeline Pipeline { get; }
        public IWindow Window { get; }

        public event EventHandler<ScreenCaptureImageInfo>? ScreenCaptured;

        public NullRenderer()
        {
            Pipeline = new Pipeline();
            Window = new Window();
        }

        public void BackgroundContextAction(Action action, bool alwaysBackground = false)
        {
            action();
        }

        public BufferHandle CreateBuffer(int size)
        {
            ulong dummyHandle = 1;
            return Unsafe.As<ulong, BufferHandle>(ref dummyHandle);
        }

        public IProgram CreateProgram(ShaderSource[] shaders, ShaderInfo info)
        {
            return new ShaderProgram();
        }

        public ISampler CreateSampler(SamplerCreateInfo info)
        {
            return new Sampler();
        }

        public void CreateSync(ulong id)
        {
        }

        public ITexture CreateTexture(TextureCreateInfo info, float scale)
        {
            return new Texture(info, scale);
        }

        public void DeleteBuffer(BufferHandle buffer)
        {
        }

        public void Dispose()
        {
        }

        public ReadOnlySpan<byte> GetBufferData(BufferHandle buffer, int offset, int size)
        {
            return new byte[size];
        }

        public Capabilities GetCapabilities()
        {
            return new Capabilities(
                api: TargetApi.OpenGL,
                vendorName: "Null",
                hasFrontFacingBug: false,
                hasVectorIndexingBug: false,
                supportsAstcCompression: true,
                supportsBc123Compression: true,
                supportsBc45Compression: true,
                supportsBc67Compression: true,
                supports3DTextureCompression: true,
                supportsBgraFormat: true,
                supportsR4G4Format: true,
                supportsFragmentShaderInterlock: true,
                supportsFragmentShaderOrderingIntel: false,
                supportsGeometryShaderPassthrough: true,
                supportsImageLoadFormatted: true,
                supportsMismatchingViewFormat: true,
                supportsCubemapView: true,
                supportsNonConstantTextureOffset: true,
                supportsShaderBallot: true,
                supportsTextureShadowLod: true,
                supportsViewportSwizzle: true,
                supportsIndirectParameters: true,
                maximumUniformBuffersPerStage: 18,
                maximumStorageBuffersPerStage: 16,
                maximumTexturesPerStage: 32,
                maximumImagesPerStage: 8,
                maximumComputeSharedMemorySize: 0x8000,
                maximumSupportedAnisotropy: 16f,
                storageBufferOffsetAlignment: 16);
        }

        public HardwareInfo GetHardwareInfo()
        {
            return new HardwareInfo("Null", "NoGPU");
        }

        public void Initialize(GraphicsDebugLevel logLevel)
        {
        }

        public IProgram LoadProgramBinary(byte[] programBinary, bool hasFragmentShader, ShaderInfo info)
        {
            return new ShaderProgram();
        }

        public void PreFrame()
        {
        }

        public ICounterEvent ReportCounter(CounterType type, EventHandler<ulong> resultHandler, bool hostReserved)
        {
            return new CounterEvent();
        }

        public void ResetCounter(CounterType type)
        {
        }

        public void Screenshot()
        {
        }

        public void SetBufferData(BufferHandle buffer, int offset, ReadOnlySpan<byte> data)
        {
        }

        public void UpdateCounters()
        {
        }

        public void WaitSync(ulong id)
        {
        }
    }
}
