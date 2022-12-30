using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Hid
{
    interface IAppletResource : IServiceObject
    {
        Result GetSharedMemoryHandle(out int arg0);
    }
}
