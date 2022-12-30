using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Irsensor
{
    interface IIrSensorSystemServer : IServiceObject
    {
        Result SetAppletResourceUserId(AppletResourceUserId arg0);
        Result RegisterAppletResourceUserId(AppletResourceUserId arg0, bool arg1);
        Result UnregisterAppletResourceUserId(AppletResourceUserId arg0);
        Result EnableAppletToGetInput(AppletResourceUserId arg0, bool arg1);
    }
}
