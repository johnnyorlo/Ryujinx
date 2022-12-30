using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Account.Detail
{
    class AsyncContext : IAsyncContext
    {
        [CmifCommand(0)]
        public Result GetSystemEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result Cancel()
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result HasDone(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetResult()
        {
            return Result.Success;
        }
    }
}
