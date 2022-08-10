using Ryujinx.Graphics.GAL;

namespace Ryujinx.Graphics.Null
{
    class Window : IWindow
    {
        public void Present(ITexture texture, ImageCrop crop, Action<object> swapBuffersCallback)
        {
        }

        public void SetSize(int width, int height)
        {
        }
    }
}
