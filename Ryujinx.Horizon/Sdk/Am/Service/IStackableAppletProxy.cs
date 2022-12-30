using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IStackableAppletProxy : IServiceObject
    {
        Result GetProcessWindingController(out IProcessWindingController arg0);
        Result GetLibraryAppletCreator(out ILibraryAppletCreator arg0);
    }
}
