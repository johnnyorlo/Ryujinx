using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Apm
{
    interface ISystemManager : IServiceObject
    {
        Result RequestPerformanceMode(PerformanceMode arg0);
        Result GetPerformanceEvent(out int arg0, EventTarget arg1);
        Result GetThrottlingState(out ThrottlingState arg0);
        Result GetLastThrottlingState(out ThrottlingState arg0);
        Result ClearLastThrottlingState();
        Result LoadAndApplySettings();
        Result SetCpuBoostMode(CpuBoostMode arg0);
        Result GetCurrentPerformanceConfiguration(out PerformanceConfiguration arg0);
    }
}
