using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface ILibraryAppletAccessor : IServiceObject
    {
        Result SetOutOfFocusApplicationSuspendingEnabled(bool arg0);
        Result PresetLibraryAppletGpuTimeSliceZero();
        Result PushInData(IStorage arg0);
        Result PopOutData(out IStorage arg0);
        Result PushExtraStorage(IStorage arg0);
        Result PushInteractiveInData(IStorage arg0);
        Result PopInteractiveOutData(out IStorage arg0);
        Result GetPopOutDataEvent(out int arg0);
        Result GetPopInteractiveOutDataEvent(out int arg0);
        Result NeedsToExitProcess(out bool arg0);
        Result GetLibraryAppletInfo(out LibraryAppletInfo arg0);
        Result RequestForAppletToGetForeground();
        Result GetIndirectLayerConsumerHandle(out ulong arg0, AppletResourceUserId arg1, ulong pid);
    }
}
