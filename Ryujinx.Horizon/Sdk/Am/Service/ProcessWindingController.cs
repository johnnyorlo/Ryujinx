using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class ProcessWindingController : IProcessWindingController
    {
        [CmifCommand(0)]
        public Result GetLaunchReason(out AppletProcessLaunchReason arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(11)]
        public Result OpenCallingLibraryApplet(out ILibraryAppletAccessor arg0)
        {
            arg0 = new LibraryAppletAccessor();

            return Result.Success;
        }

        [CmifCommand(21)]
        public Result PushContext(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(22)]
        public Result PopContext(out IStorage arg0)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(23)]
        public Result CancelWindingReservation()
        {
            return Result.Success;
        }

        [CmifCommand(30)]
        public Result WindAndDoReserved()
        {
            return Result.Success;
        }

        [CmifCommand(40)]
        public Result ReserveToStartAndWaitAndUnwindThis(ILibraryAppletAccessor arg0)
        {
            return Result.Success;
        }

        [CmifCommand(41)]
        public Result ReserveToStartAndWait(ILibraryAppletAccessor arg0)
        {
            return Result.Success;
        }
    }
}
