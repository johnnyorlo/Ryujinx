using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Apm
{
    class Session : ISession
    {
        [CmifCommand(0)]
        public Result SetPerformanceConfiguration(PerformanceMode arg0, PerformanceConfiguration arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetPerformanceConfiguration(out PerformanceConfiguration arg0, PerformanceMode arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result SetCpuOverclockEnabled(bool arg0)
        {
            return Result.Success;
        }
    }
}
