using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Nim.ShopServiceAccessTypes;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Nim.Detail
{
    interface IShopServiceAccessSystemInterface : IServiceObject
    {
        Result RegisterSpecialClient(ulong arg0, ulong arg1, ClientCategory arg2, ulong pid);
        Result UnregisterSpecialClient(ulong arg0, ulong pid);
    }
}
