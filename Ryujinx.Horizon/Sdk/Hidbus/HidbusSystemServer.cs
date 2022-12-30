using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Hidbus
{
    class HidbusSystemServer : IHidbusSystemServer
    {
        [CmifCommand(500)]
        public Result SetAppletResourceUserId(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(501)]
        public Result RegisterAppletResourceUserId(AppletResourceUserId arg0, int arg1)
        {
            return Result.Success;
        }

        [CmifCommand(502)]
        public Result UnregisterAppletResourceUserId(AppletResourceUserId arg0)
        {
            return Result.Success;
        }
    }
}
