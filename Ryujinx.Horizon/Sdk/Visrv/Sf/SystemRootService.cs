using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Vi;

namespace Ryujinx.Horizon.Sdk.Visrv.Sf
{
    class SystemRootService : ISystemRootService
    {
        [CmifCommand(1)]
        public Result GetDisplayService(out IApplicationDisplayService arg0, uint arg1)
        {
            arg0 = new ApplicationDisplayService();

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetDisplayServiceWithProxyNameExchange(out IApplicationDisplayService arg0, uint arg1, ProxyName arg2)
        {
            arg0 = new ApplicationDisplayService();

            return Result.Success;
        }
    }
}
