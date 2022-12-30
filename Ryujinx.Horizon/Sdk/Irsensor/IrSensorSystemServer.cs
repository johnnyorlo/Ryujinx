using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Irsensor
{
    class IrSensorSystemServer : IIrSensorSystemServer
    {
        [CmifCommand(500)]
        public Result SetAppletResourceUserId(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(501)]
        public Result RegisterAppletResourceUserId(AppletResourceUserId arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(502)]
        public Result UnregisterAppletResourceUserId(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(503)]
        public Result EnableAppletToGetInput(AppletResourceUserId arg0, bool arg1)
        {
            return Result.Success;
        }
    }
}
