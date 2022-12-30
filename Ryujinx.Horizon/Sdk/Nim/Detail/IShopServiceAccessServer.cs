using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Nim.Detail
{
    interface IShopServiceAccessServer : IServiceObject
    {
        Result CreateAccessorInterface(out IShopServiceAccessor arg0, byte arg1);
    }
}
