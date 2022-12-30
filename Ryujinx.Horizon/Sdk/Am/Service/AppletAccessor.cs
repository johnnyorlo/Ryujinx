using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class AppletAccessor : IAppletAccessor
    {
        [CmifCommand(0)]
        public Result GetIntegratedAppletPointer([CopyHandle] out IntegratedApplet arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(0)]
        public Result GetAppletStateChangedEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result IsCompleted(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result Start()
        {
            return Result.Success;
        }

        [CmifCommand(20)]
        public Result RequestExit()
        {
            return Result.Success;
        }

        [CmifCommand(25)]
        public Result Terminate()
        {
            return Result.Success;
        }

        [CmifCommand(30)]
        public Result GetResult()
        {
            return Result.Success;
        }
    }
}
