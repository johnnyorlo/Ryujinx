using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Visrv.Sf
{
    interface IApplicationRootService : IServiceObject
    {
        Result GetDisplayServiceWithWorkaround(out IApplicationDisplayService arg0, uint arg1);
        Result GetDisplayService(out IApplicationDisplayService arg0, uint arg1);
    }
}
