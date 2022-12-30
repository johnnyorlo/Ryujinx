using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IWindowController : IServiceObject
    {
        Result CreateWindow(out IWindow arg0, WindowCreationOption arg1);
        Result GetAppletResourceUserId(out AppletResourceUserId arg0);
        Result GetAppletResourceUserIdOfCallerApplet(out AppletResourceUserId arg0);
        Result AcquireForegroundRights();
        Result ReleaseForegroundRights();
        Result RejectToChangeIntoBackground();
        Result SetAppletWindowVisibility(bool arg0);
        Result SetAppletGpuTimeSlice(long arg0);
    }
}
