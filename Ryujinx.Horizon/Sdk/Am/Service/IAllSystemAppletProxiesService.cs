using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IAllSystemAppletProxiesService : IServiceObject
    {
        Result OpenSystemAppletProxy(out ISystemAppletProxy arg0, ulong arg1, int arg2);
        Result OpenLibraryAppletProxyOld(out ILibraryAppletProxy arg0, ulong arg1, int arg2);
        Result OpenLibraryAppletProxy(out ILibraryAppletProxy arg0, ulong arg1, int arg2, AppletAttribute arg3);
        Result OpenOverlayAppletProxy(out IOverlayAppletProxy arg0, ulong arg1, int arg2);
        Result OpenSystemApplicationProxy(out IApplicationProxy arg0, ulong arg1, int arg2);
        Result CreateSelfLibraryAppletCreatorForDevelop(out ILibraryAppletCreator arg0, ulong arg1);
        Result GetSystemAppletControllerForDebug(out ISystemAppletControllerForDebug arg0);
        Result GetDebugFunctions(out IDebugFunctions arg0);
    }
}
