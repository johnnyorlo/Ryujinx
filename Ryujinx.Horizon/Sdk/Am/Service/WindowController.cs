using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class WindowController : IWindowController
    {
        [CmifCommand(0)]
        public Result CreateWindow(out IWindow arg0, WindowCreationOption arg1)
        {
            arg0 = new Window();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetAppletResourceUserId(out AppletResourceUserId arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetAppletResourceUserIdOfCallerApplet(out AppletResourceUserId arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result AcquireForegroundRights()
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result ReleaseForegroundRights()
        {
            return Result.Success;
        }

        [CmifCommand(12)]
        public Result RejectToChangeIntoBackground()
        {
            return Result.Success;
        }

        [CmifCommand(20)]
        public Result SetAppletWindowVisibility(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(21)]
        public Result SetAppletGpuTimeSlice(long arg0)
        {
            return Result.Success;
        }
    }
}
