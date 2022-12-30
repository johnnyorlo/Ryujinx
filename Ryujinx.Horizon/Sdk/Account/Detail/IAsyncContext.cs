using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Account.Detail
{
    interface IAsyncContext : IServiceObject
    {
        Result GetSystemEvent(out int arg0);
        Result Cancel();
        Result HasDone(out bool arg0);
        Result GetResult();
    }
}
