using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Npns
{
    class NotificationReceiver : INotificationReceiver
    {
        [CmifCommand(1)]
        public Result ListenTo(ApplicationId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result ListenToMyApplicationId(ulong arg0, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(3)]
        public Result Receive([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0, ushort arg1)
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result GetReceiveEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
