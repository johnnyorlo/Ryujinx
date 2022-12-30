using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Npns
{
    interface IAsyncContextBase : IServiceObject
    {
        Result GetEvent(out int arg0);
        Result Cancel();
        Result GetResult();
    }
}
