using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Apm
{
    interface IManager : IServiceObject
    {
        Result OpenSession(out ISession arg0);
        Result GetPerformanceMode(out PerformanceMode arg0);
        Result IsCpuOverclockEnabled(out bool arg0);
    }
}
