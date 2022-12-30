using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Npns
{
    class NpnsSystem : INpnsSystem
    {
        [CmifCommand(6)]
        public Result ListenUndelivered()
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result SubscribeTopic([Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(12)]
        public Result UnsubscribeTopic([Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(13)]
        public Result QueryIsTopicExist(out bool arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(22)]
        public Result CreateTokenWithApplicationId(out NotificationToken arg0, Uid arg1, ApplicationId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(24)]
        public Result DestroyTokenWithApplicationId(Uid arg0, ApplicationId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(27)]
        public Result DestroyTokenAll(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(31)]
        public Result UploadTokenToBaaS(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(32)]
        public Result DestroyTokenForBaaS(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(33)]
        public Result CreateTokenForBaas(out NotificationToken arg0, Uid arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(34)]
        public Result SetBaasDeviceAccountIdList([Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<ulong> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(105)]
        public Result GetPlayReportRequestEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(112)]
        public Result CreateJid()
        {
            return Result.Success;
        }

        [CmifCommand(113)]
        public Result DestroyJid()
        {
            return Result.Success;
        }

        [CmifCommand(114)]
        public Result AttachJid([Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(115)]
        public Result DetachJid([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<sbyte> arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<sbyte> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(155)]
        public Result CreateTokenWithApplicationIdAsync(out ICreateTokenAsyncContext arg0, Uid arg1, ApplicationId arg2)
        {
            arg0 = new CreateTokenAsyncContext();

            return Result.Success;
        }

        [CmifCommand(161)]
        public Result GetRequestChangeStateCancelEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(162)]
        public Result RequestChangeStateForceTimedWithCancelEvent(int arg0, TimeSpanType arg1)
        {
            return Result.Success;
        }

        [CmifCommand(201)]
        public Result RequestChangeStateForceTimed(int arg0, TimeSpanType arg1)
        {
            return Result.Success;
        }

        [CmifCommand(202)]
        public Result RequestChangeStateForceAsync(int arg0)
        {
            return Result.Success;
        }
    }
}
