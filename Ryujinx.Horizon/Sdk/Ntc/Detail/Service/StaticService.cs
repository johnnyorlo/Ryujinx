using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Nifm;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Ntc.Detail.Service
{
    class StaticService : IStaticService
    {
        [CmifCommand(0)]
        public Result GetEnsureNetworkClockAvailabilityService(out IEnsureNetworkClockAvailabilityService arg0, int arg1, ClientId arg2)
        {
            arg0 = new EnsureNetworkClockAvailabilityService();

            return Result.Success;
        }

        [CmifCommand(100)]
        public Result SuspendAutonomicTimeCorrection()
        {
            return Result.Success;
        }

        [CmifCommand(101)]
        public Result ResumeAutonomicTimeCorrection()
        {
            return Result.Success;
        }
    }
}
