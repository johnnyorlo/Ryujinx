using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Apm
{
    interface ISession : IServiceObject
    {
        Result SetPerformanceConfiguration(PerformanceMode arg0, PerformanceConfiguration arg1);
        Result GetPerformanceConfiguration(out PerformanceConfiguration arg0, PerformanceMode arg1);
        Result SetCpuOverclockEnabled(bool arg0);
    }
}
