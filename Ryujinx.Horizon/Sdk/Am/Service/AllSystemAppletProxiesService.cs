using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class AllSystemAppletProxiesService : IAllSystemAppletProxiesService
    {
        [CmifCommand(100)]
        public Result OpenSystemAppletProxy(out ISystemAppletProxy arg0, ulong arg1, [CopyHandle] int arg2)
        {
            arg0 = new SystemAppletProxy();

            return Result.Success;
        }

        [CmifCommand(200)]
        public Result OpenLibraryAppletProxyOld(out ILibraryAppletProxy arg0, ulong arg1, [CopyHandle] int arg2)
        {
            arg0 = new LibraryAppletProxy();

            return Result.Success;
        }

        [CmifCommand(201)]
        public Result OpenLibraryAppletProxy(out ILibraryAppletProxy arg0, ulong arg1, [CopyHandle] int arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x80)] AppletAttribute arg3)
        {
            arg0 = new LibraryAppletProxy();

            return Result.Success;
        }

        [CmifCommand(300)]
        public Result OpenOverlayAppletProxy(out IOverlayAppletProxy arg0, ulong arg1, [CopyHandle] int arg2)
        {
            arg0 = new OverlayAppletProxy();

            return Result.Success;
        }

        [CmifCommand(350)]
        public Result OpenSystemApplicationProxy(out IApplicationProxy arg0, ulong arg1, [CopyHandle] int arg2)
        {
            arg0 = new ApplicationProxy();

            return Result.Success;
        }

        [CmifCommand(400)]
        public Result CreateSelfLibraryAppletCreatorForDevelop(out ILibraryAppletCreator arg0, ulong arg1)
        {
            arg0 = new LibraryAppletCreator();

            return Result.Success;
        }

        [CmifCommand(410)]
        public Result GetSystemAppletControllerForDebug(out ISystemAppletControllerForDebug arg0)
        {
            arg0 = new SystemAppletControllerForDebug();

            return Result.Success;
        }

        [CmifCommand(1000)]
        public Result GetDebugFunctions(out IDebugFunctions arg0)
        {
            arg0 = new DebugFunctions();

            return Result.Success;
        }
    }
}
