using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Time;

namespace Ryujinx.Horizon.Sdk.Ntc.Detail.Service
{
    interface IEnsureNetworkClockAvailabilityService : IServiceObject
    {
        Result StartTask();
        Result GetSystemEventReadableHandle(out int arg0);
        Result GetResult();
        Result Cancel();
        Result IsProcessing(out bool arg0);
        Result GetServerTime(out PosixTime arg0);
    }
}
