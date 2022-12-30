using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IApplicationProxyService : IServiceObject
    {
        Result OpenApplicationProxy(out IApplicationProxy arg0, ulong arg1, int arg2);
    }
}
