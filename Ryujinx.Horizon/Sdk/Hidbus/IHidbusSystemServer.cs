using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Hidbus
{
    interface IHidbusSystemServer : IServiceObject
    {
        Result SetAppletResourceUserId(AppletResourceUserId arg0);
        Result RegisterAppletResourceUserId(AppletResourceUserId arg0, int arg1);
        Result UnregisterAppletResourceUserId(AppletResourceUserId arg0);
    }
}
