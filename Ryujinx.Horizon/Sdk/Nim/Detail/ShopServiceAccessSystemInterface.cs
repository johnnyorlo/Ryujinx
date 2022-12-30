using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Nim.ShopServiceAccessTypes;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Nim.Detail
{
    class ShopServiceAccessSystemInterface : IShopServiceAccessSystemInterface
    {
        [CmifCommand(0)]
        public Result RegisterSpecialClient(ulong arg0, ulong arg1, ClientCategory arg2)
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result UnregisterSpecialClient(ulong arg0)
        {
            return Result.Success;
        }
    }
}
