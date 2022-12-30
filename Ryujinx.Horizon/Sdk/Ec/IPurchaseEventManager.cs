using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Ec.Srv.Detail;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Ec
{
    interface IPurchaseEventManager : IServiceObject
    {
        Result SetDefaultDeliveryTarget(ulong arg0, ReadOnlySpan<int> arg1, ulong pid);
        Result SetDeliveryTarget(ulong arg0, ReadOnlySpan<int> arg1);
        Result GetPurchasedEventReadableHandle(out int arg0);
        Result PopPurchasedProductInfo(out PurchasedProductInfo arg0);
        Result PopPurchasedProductInfoWithUid(out PurchasedProductInfo arg0, Uid arg1);
    }
}
