using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Olsc.Srv
{
    interface IAsyncResult : IServiceObject
    {
        Result GetResult();
        Result Cancel();
        Result IsAvailable(out bool arg0);
        Result GetSystemEvent(out int arg0);
    }
}
