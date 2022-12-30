using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class LockAccessor : ILockAccessor
    {
        [CmifCommand(1)]
        public Result TryLock(out bool arg0, [CopyHandle] out int arg1, bool arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result Unlock()
        {
            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result IsLocked(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
