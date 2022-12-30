using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Nim.ShopServiceAccessTypes;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Nim.Detail
{
    interface IShopServiceAccessor : IServiceObject
    {
        Result CreateAsyncInterface(out int arg0, out IShopServiceAsync arg1, FixedParams arg2);
    }
}
