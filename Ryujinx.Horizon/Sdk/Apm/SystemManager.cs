using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Apm
{
    class SystemManager : ISystemManager
    {
        [CmifCommand(0)]
        public Result RequestPerformanceMode(PerformanceMode arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetPerformanceEvent([CopyHandle] out int arg0, EventTarget arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetThrottlingState(out ThrottlingState arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetLastThrottlingState(out ThrottlingState arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result ClearLastThrottlingState()
        {
            return Result.Success;
        }

        [CmifCommand(5)]
        public Result LoadAndApplySettings()
        {
            return Result.Success;
        }

        [CmifCommand(6)]
        public Result SetCpuBoostMode(CpuBoostMode arg0)
        {
            return Result.Success;
        }

        [CmifCommand(7)]
        public Result GetCurrentPerformanceConfiguration(out PerformanceConfiguration arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
