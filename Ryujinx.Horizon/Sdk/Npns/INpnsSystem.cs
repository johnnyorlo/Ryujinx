using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Npns
{
    interface INpnsSystem : IServiceObject
    {
        Result ListenUndelivered();
        Result SubscribeTopic(ReadOnlySpan<sbyte> arg0);
        Result UnsubscribeTopic(ReadOnlySpan<sbyte> arg0);
        Result QueryIsTopicExist(out bool arg0, ReadOnlySpan<sbyte> arg1);
        Result CreateTokenWithApplicationId(out NotificationToken arg0, Uid arg1, ApplicationId arg2);
        Result DestroyTokenWithApplicationId(Uid arg0, ApplicationId arg1);
        Result DestroyTokenAll(Uid arg0);
        Result UploadTokenToBaaS(Uid arg0);
        Result DestroyTokenForBaaS(Uid arg0);
        Result CreateTokenForBaas(out NotificationToken arg0, Uid arg1);
        Result SetBaasDeviceAccountIdList(ReadOnlySpan<ulong> arg0);
        Result GetPlayReportRequestEvent(out int arg0);
        Result CreateJid();
        Result DestroyJid();
        Result AttachJid(ReadOnlySpan<sbyte> arg0, ReadOnlySpan<sbyte> arg1);
        Result DetachJid(Span<sbyte> arg0, Span<sbyte> arg1);
        Result CreateTokenWithApplicationIdAsync(out ICreateTokenAsyncContext arg0, Uid arg1, ApplicationId arg2);
        Result GetRequestChangeStateCancelEvent(out int arg0);
        Result RequestChangeStateForceTimedWithCancelEvent(int arg0, TimeSpanType arg1);
        Result RequestChangeStateForceTimed(int arg0, TimeSpanType arg1);
        Result RequestChangeStateForceAsync(int arg0);
    }
}
