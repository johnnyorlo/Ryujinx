using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class LibraryAppletProxy : ILibraryAppletProxy
    {
        [CmifCommand(20)]
        public Result OpenLibraryAppletSelfAccessor(out ILibraryAppletSelfAccessor arg0)
        {
            arg0 = new LibraryAppletSelfAccessor();

            return Result.Success;
        }

        [CmifCommand(21)]
        public Result GetAppletCommonFunctions(out IAppletCommonFunctions arg0)
        {
            arg0 = new AppletCommonFunctions();

            return Result.Success;
        }
    }
}
