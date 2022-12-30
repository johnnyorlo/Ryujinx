using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class StackableAppletProxy : IStackableAppletProxy
    {
        [CmifCommand(10)]
        public Result GetProcessWindingController(out IProcessWindingController arg0)
        {
            arg0 = new ProcessWindingController();

            return Result.Success;
        }

        [CmifCommand(11)]
        public Result GetLibraryAppletCreator(out ILibraryAppletCreator arg0)
        {
            arg0 = new LibraryAppletCreator();

            return Result.Success;
        }
    }
}
