using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Nifm;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Ntc.Detail.Service
{
    interface IStaticService : IServiceObject
    {
        Result GetEnsureNetworkClockAvailabilityService(out IEnsureNetworkClockAvailabilityService arg0, int arg1, ClientId arg2);
        Result SuspendAutonomicTimeCorrection();
        Result ResumeAutonomicTimeCorrection();
    }
}
