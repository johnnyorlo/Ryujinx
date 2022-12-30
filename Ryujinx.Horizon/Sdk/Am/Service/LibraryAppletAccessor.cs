using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class LibraryAppletAccessor : ILibraryAppletAccessor
    {
        [CmifCommand(50)]
        public Result SetOutOfFocusApplicationSuspendingEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(60)]
        public Result PresetLibraryAppletGpuTimeSliceZero()
        {
            return Result.Success;
        }

        [CmifCommand(100)]
        public Result PushInData(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(101)]
        public Result PopOutData(out IStorage arg0)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(102)]
        public Result PushExtraStorage(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(103)]
        public Result PushInteractiveInData(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(104)]
        public Result PopInteractiveOutData(out IStorage arg0)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(105)]
        public Result GetPopOutDataEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(106)]
        public Result GetPopInteractiveOutDataEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(110)]
        public Result NeedsToExitProcess(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(120)]
        public Result GetLibraryAppletInfo(out LibraryAppletInfo arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(150)]
        public Result RequestForAppletToGetForeground()
        {
            return Result.Success;
        }

        [CmifCommand(160)]
        public Result GetIndirectLayerConsumerHandle(out ulong arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
