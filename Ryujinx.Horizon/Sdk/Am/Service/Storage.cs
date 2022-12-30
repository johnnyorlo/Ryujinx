using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class Storage : IStorage
    {
        [CmifCommand(0)]
        public Result Open(out IStorageAccessor arg0)
        {
            arg0 = new StorageAccessor();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result OpenTransferStorage(out ITransferStorageAccessor arg0)
        {
            arg0 = new TransferStorageAccessor();

            return Result.Success;
        }

        [CmifCommand(0)]
        public Result GetAndInvalidate(out IStorage arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
