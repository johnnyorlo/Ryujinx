using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Apm
{
    class Manager : IManager
    {
        [CmifCommand(0)]
        public Result OpenSession(out ISession arg0)
        {
            arg0 = new Session();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetPerformanceMode(out PerformanceMode arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(6)]
        public Result IsCpuOverclockEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
