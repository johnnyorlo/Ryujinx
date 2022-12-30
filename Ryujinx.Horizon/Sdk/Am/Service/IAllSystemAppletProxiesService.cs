using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IAllSystemAppletProxiesService : IServiceObject
    {
        Result OpenSystemAppletProxy(out ISystemAppletProxy arg0, ulong arg1, int arg2, ulong pid);
        Result OpenLibraryAppletProxyOld(out ILibraryAppletProxy arg0, ulong arg1, int arg2, ulong pid);
        Result OpenLibraryAppletProxy(out ILibraryAppletProxy arg0, ulong arg1, int arg2, in AppletAttribute arg3, ulong pid);
        Result OpenOverlayAppletProxy(out IOverlayAppletProxy arg0, ulong arg1, int arg2, ulong pid);
        Result OpenSystemApplicationProxy(out IApplicationProxy arg0, ulong arg1, int arg2, ulong pid);
        Result CreateSelfLibraryAppletCreatorForDevelop(out ILibraryAppletCreator arg0, ulong arg1, ulong pid);
        Result GetSystemAppletControllerForDebug(out ISystemAppletControllerForDebug arg0);
        Result GetDebugFunctions(out IDebugFunctions arg0);
    }
}
