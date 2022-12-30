using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Ec.Srv.Detail;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Ec
{
    class PurchaseEventManager : IPurchaseEventManager
    {
        [CmifCommand(0)]
        public Result SetDefaultDeliveryTarget(ulong arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<int> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result SetDeliveryTarget(ulong arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<int> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetPurchasedEventReadableHandle([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result PopPurchasedProductInfo(out PurchasedProductInfo arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result PopPurchasedProductInfoWithUid(out PurchasedProductInfo arg0, Uid arg1)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
