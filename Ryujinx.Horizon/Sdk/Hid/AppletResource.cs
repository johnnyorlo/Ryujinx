using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Hid
{
    class AppletResource : IAppletResource
    {
        [CmifCommand(0)]
        public Result GetSharedMemoryHandle([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
