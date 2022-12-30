using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Ec;
using Ryujinx.Horizon.Sdk.Err;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Aocsrv.Detail
{
    interface IAddOnContentManager : IServiceObject
    {
        Result CountAddOnContent(out int arg0, ulong arg1);
        Result ListAddOnContent(out int arg0, Span<int> arg1, ulong arg2, int arg3, int arg4);
        Result GetAddOnContentBaseId(out ulong arg0, ulong arg1);
        Result PrepareAddOnContent(int arg0, ulong arg1);
        Result GetAddOnContentListChangedEvent(out int arg0);
        Result GetAddOnContentLostErrorCode(out ErrorCode arg0, ReadOnlySpan<int> arg1, ulong arg2);
        Result GetAddOnContentListChangedEventWithProcessId(out int arg0, ulong arg1);
        Result NotifyMountAddOnContent(DataId arg0, ulong arg1);
        Result NotifyUnmountAddOnContent(DataId arg0, ulong arg1);
        Result IsAddOnContentMountedForDebug(out bool arg0, DataId arg1, ulong arg2);
        Result CheckAddOnContentMountStatus(ulong arg0);
        Result CreateEcPurchasedEventManager(out IPurchaseEventManager arg0);
        Result CreatePermanentEcPurchasedEventManager(out IPurchaseEventManager arg0, ulong arg1);
        Result CreateContentsServiceManager(out IContentsServiceManager arg0);
        Result SetRequiredAddOnContentsOnContentsAvailabilityTransition(ulong arg0, ReadOnlySpan<int> arg1);
    }
}
