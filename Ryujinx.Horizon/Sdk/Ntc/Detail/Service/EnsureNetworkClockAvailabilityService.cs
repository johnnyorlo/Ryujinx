using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Time;

namespace Ryujinx.Horizon.Sdk.Ntc.Detail.Service
{
    class EnsureNetworkClockAvailabilityService : IEnsureNetworkClockAvailabilityService
    {
        [CmifCommand(0)]
        public Result StartTask()
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetSystemEventReadableHandle([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetResult()
        {
            return Result.Success;
        }

        [CmifCommand(3)]
        public Result Cancel()
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result IsProcessing(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(5)]
        public Result GetServerTime(out PosixTime arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
