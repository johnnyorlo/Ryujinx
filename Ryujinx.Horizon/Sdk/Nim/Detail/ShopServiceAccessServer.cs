using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Nim.Detail
{
    class ShopServiceAccessServer : IShopServiceAccessServer
    {
        [CmifCommand(0)]
        public Result CreateAccessorInterface(out IShopServiceAccessor arg0, byte arg1)
        {
            arg0 = new ShopServiceAccessor();

            return Result.Success;
        }
    }
}
