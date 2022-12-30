using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Npns
{
    class AsyncContextBase : IAsyncContextBase
    {
        [CmifCommand(1)]
        public Result GetEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result Cancel()
        {
            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetResult()
        {
            return Result.Success;
        }
    }
}
