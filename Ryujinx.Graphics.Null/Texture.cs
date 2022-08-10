using Ryujinx.Graphics.GAL;

namespace Ryujinx.Graphics.Null
{
    class Texture : ITexture
    {
        private readonly TextureCreateInfo _info;

        public int Width => _info.Width;
        public int Height => _info.Height;

        public float ScaleFactor { get; }

        public Texture(TextureCreateInfo info, float scale)
        {
            _info = info;
            ScaleFactor = scale;
        }

        public void CopyTo(ITexture destination, int firstLayer, int firstLevel)
        {
        }

        public void CopyTo(ITexture destination, int srcLayer, int dstLayer, int srcLevel, int dstLevel)
        {
        }

        public void CopyTo(ITexture destination, Extents2D srcRegion, Extents2D dstRegion, bool linearFilter)
        {
        }

        public ITexture CreateView(TextureCreateInfo info, int firstLayer, int firstLevel)
        {
            return new Texture(info, ScaleFactor);
        }

        public ReadOnlySpan<byte> GetData()
        {
            int size = 0;
            int levels = _info.GetLevelsClamped();

            for (int level = 0; level < levels; level++)
            {
                size += _info.GetMipSize(level);
            }

            return new byte[size];
        }

        public ReadOnlySpan<byte> GetData(int layer, int level)
        {
            int size = _info.GetMipSize(level);

            return new byte[size];
        }

        public void Release()
        {
        }

        public void SetData(ReadOnlySpan<byte> data)
        {
        }

        public void SetData(ReadOnlySpan<byte> data, int layer, int level)
        {
        }

        public void SetStorage(BufferRange buffer)
        {
        }
    }
}
