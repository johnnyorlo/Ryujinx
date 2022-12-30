using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Nim.ShopServiceAccessTypes;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Nim.Detail
{
    class ShopServiceAccessor : IShopServiceAccessor
    {
        [CmifCommand(0)]
        public Result CreateAsyncInterface([CopyHandle] out int arg0, out IShopServiceAsync arg1, FixedParams arg2)
        {
            arg0 = default;
            arg1 = new ShopServiceAsync();

            return Result.Success;
        }
    }
}
