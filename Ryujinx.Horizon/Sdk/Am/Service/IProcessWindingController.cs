using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IProcessWindingController : IServiceObject
    {
        Result GetLaunchReason(out AppletProcessLaunchReason arg0);
        Result OpenCallingLibraryApplet(out ILibraryAppletAccessor arg0);
        Result PushContext(IStorage arg0);
        Result PopContext(out IStorage arg0);
        Result CancelWindingReservation();
        Result WindAndDoReserved();
        Result ReserveToStartAndWaitAndUnwindThis(ILibraryAppletAccessor arg0);
        Result ReserveToStartAndWait(ILibraryAppletAccessor arg0);
    }
}
