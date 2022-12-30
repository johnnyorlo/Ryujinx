using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class HomeMenuFunctions : IHomeMenuFunctions
    {
        [CmifCommand(10)]
        public Result RequestToGetForeground()
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result LockForeground()
        {
            return Result.Success;
        }

        [CmifCommand(12)]
        public Result UnlockForeground()
        {
            return Result.Success;
        }

        [CmifCommand(20)]
        public Result PopFromGeneralChannel(out IStorage arg0)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(21)]
        public Result GetPopFromGeneralChannelEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(30)]
        public Result GetHomeButtonWriterLockAccessor(out ILockAccessor arg0)
        {
            arg0 = new LockAccessor();

            return Result.Success;
        }

        [CmifCommand(31)]
        public Result GetWriterLockAccessorEx(out ILockAccessor arg0, int arg1)
        {
            arg0 = new LockAccessor();

            return Result.Success;
        }

        [CmifCommand(40)]
        public Result IsSleepEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(41)]
        public Result IsRebootEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(100)]
        public Result PopRequestLaunchApplicationForDebug(out ApplicationId arg0, out int arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<Uid> arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(110)]
        public Result IsForceTerminateApplicationDisabledForDebug(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(200)]
        public Result LaunchDevMenu()
        {
            return Result.Success;
        }

        [CmifCommand(1000)]
        public Result SetLastApplicationExitReason(int arg0)
        {
            return Result.Success;
        }
    }
}
