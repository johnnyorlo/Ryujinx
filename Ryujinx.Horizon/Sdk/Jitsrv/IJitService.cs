using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Jitsrv
{
    interface IJitService : IServiceObject
    {
        Result CreateJitEnvironment(out IJitEnvironment arg0, int arg1, int arg2, ulong arg3, int arg4, ulong arg5);
    }
}
