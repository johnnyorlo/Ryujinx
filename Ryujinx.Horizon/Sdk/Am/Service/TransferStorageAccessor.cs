using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class TransferStorageAccessor : ITransferStorageAccessor
    {
        [CmifCommand(0)]
        public Result GetSize(out long arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetHandle([CopyHandle] out int arg0, out ulong arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }
    }
}
