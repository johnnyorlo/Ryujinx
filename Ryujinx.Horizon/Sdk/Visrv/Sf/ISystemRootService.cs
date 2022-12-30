using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Vi;

namespace Ryujinx.Horizon.Sdk.Visrv.Sf
{
    interface ISystemRootService : IServiceObject
    {
        Result GetDisplayService(out IApplicationDisplayService arg0, uint arg1);
        Result GetDisplayServiceWithProxyNameExchange(out IApplicationDisplayService arg0, uint arg1, ProxyName arg2);
    }
}
