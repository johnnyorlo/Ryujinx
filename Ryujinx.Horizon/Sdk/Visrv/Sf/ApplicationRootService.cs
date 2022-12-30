using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Visrv.Sf
{
    class ApplicationRootService : IApplicationRootService
    {
        [CmifCommand(0)]
        public Result GetDisplayServiceWithWorkaround(out IApplicationDisplayService arg0, uint arg1)
        {
            arg0 = new ApplicationDisplayService();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetDisplayService(out IApplicationDisplayService arg0, uint arg1)
        {
            arg0 = new ApplicationDisplayService();

            return Result.Success;
        }
    }
}
