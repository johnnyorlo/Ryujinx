using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface ILibraryAppletProxy : IServiceObject
    {
        Result OpenLibraryAppletSelfAccessor(out ILibraryAppletSelfAccessor arg0);
        Result GetAppletCommonFunctions(out IAppletCommonFunctions arg0);
    }
}
