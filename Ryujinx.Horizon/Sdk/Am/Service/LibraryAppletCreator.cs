using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class LibraryAppletCreator : ILibraryAppletCreator
    {
        [CmifCommand(0)]
        public Result CreateLibraryApplet(out ILibraryAppletAccessor arg0, uint arg1, uint arg2)
        {
            arg0 = new LibraryAppletAccessor();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result TerminateAllLibraryApplets()
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result AreAnyLibraryAppletsLeft(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result CreateStorage(out IStorage arg0, long arg1)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(11)]
        public Result CreateTransferMemoryStorage(out IStorage arg0, [CopyHandle] int arg1, long arg2, bool arg3)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(12)]
        public Result CreateHandleStorage(out IStorage arg0, [CopyHandle] int arg1, long arg2)
        {
            arg0 = new Storage();

            return Result.Success;
        }
    }
}
