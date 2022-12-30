using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class StorageChannel : IStorageChannel
    {
        [CmifCommand(0)]
        public Result Push(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result Unpop(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result Pop(out IStorage arg0)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetPopEventHandle([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result Clear()
        {
            return Result.Success;
        }
    }
}
