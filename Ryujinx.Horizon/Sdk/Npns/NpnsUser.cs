using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Npns
{
    class NpnsUser : INpnsUser
    {
        [CmifCommand(1)]
        public Result ListenAll()
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result ListenTo(ApplicationId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(3)]
        public Result Receive([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0, ushort arg1)
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result ReceiveRaw([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0, ushort arg1)
        {
            return Result.Success;
        }

        [CmifCommand(5)]
        public Result GetReceiveEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(7)]
        public Result GetStateChangeEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(21)]
        public Result CreateToken(out NotificationToken arg0, Uid arg1, ulong arg2, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(23)]
        public Result DestroyToken(Uid arg0, ulong arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(25)]
        public Result QueryIsTokenValid(out bool arg0, NotificationToken arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(26)]
        public Result ListenToMyApplicationId(ulong arg0, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(101)]
        public Result Suspend()
        {
            return Result.Success;
        }

        [CmifCommand(102)]
        public Result Resume()
        {
            return Result.Success;
        }

        [CmifCommand(103)]
        public Result GetState(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(104)]
        public Result GetStatistics([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(111)]
        public Result GetJid([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<sbyte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(120)]
        public Result CreateNotificationReceiver(out INotificationReceiver arg0)
        {
            arg0 = new NotificationReceiver();

            return Result.Success;
        }

        [CmifCommand(151)]
        public Result GetStateWithHandover(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(152)]
        public Result GetStateChangeEventWithHandover([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(153)]
        public Result GetDropEventWithHandover([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(154)]
        public Result CreateTokenAsync(out ICreateTokenAsyncContext arg0, Uid arg1, ulong arg2, [ClientProcessId] ulong pid)
        {
            arg0 = new CreateTokenAsyncContext();

            return Result.Success;
        }
    }
}
