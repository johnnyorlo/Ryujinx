using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Ec;
using Ryujinx.Horizon.Sdk.Err;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Aocsrv.Detail
{
    class AddOnContentManager : IAddOnContentManager
    {
        [CmifCommand(2)]
        public Result CountAddOnContent(out int arg0, ulong arg1, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result ListAddOnContent(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<int> arg1, ulong arg2, int arg3, int arg4, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(5)]
        public Result GetAddOnContentBaseId(out ulong arg0, ulong arg1, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(7)]
        public Result PrepareAddOnContent(int arg0, ulong arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(8)]
        public Result GetAddOnContentListChangedEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(9)]
        public Result GetAddOnContentLostErrorCode(out ErrorCode arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<int> arg1, ulong arg2, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result GetAddOnContentListChangedEventWithProcessId([CopyHandle] out int arg0, ulong arg1, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(11)]
        public Result NotifyMountAddOnContent(DataId arg0, ulong arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(12)]
        public Result NotifyUnmountAddOnContent(DataId arg0, ulong arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(13)]
        public Result IsAddOnContentMountedForDebug(out bool arg0, DataId arg1, ulong arg2, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(50)]
        public Result CheckAddOnContentMountStatus(ulong arg0, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(100)]
        public Result CreateEcPurchasedEventManager(out IPurchaseEventManager arg0)
        {
            arg0 = new PurchaseEventManager();

            return Result.Success;
        }

        [CmifCommand(101)]
        public Result CreatePermanentEcPurchasedEventManager(out IPurchaseEventManager arg0, ulong arg1, [ClientProcessId] ulong pid)
        {
            arg0 = new PurchaseEventManager();

            return Result.Success;
        }

        [CmifCommand(110)]
        public Result CreateContentsServiceManager(out IContentsServiceManager arg0)
        {
            arg0 = new ContentsServiceManager();

            return Result.Success;
        }

        [CmifCommand(200)]
        public Result SetRequiredAddOnContentsOnContentsAvailabilityTransition(ulong arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<int> arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }
    }
}
