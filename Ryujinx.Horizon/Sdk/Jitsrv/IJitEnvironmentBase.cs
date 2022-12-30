using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Jitsrv
{
    interface IJitEnvironmentBase : IServiceObject
    {
        Result LoadPlugin(ReadOnlySpan<byte> arg0, ReadOnlySpan<byte> arg1, int arg2, ulong arg3);
        Result GetCodeAddress(out ulong arg0, out ulong arg1);
    }
}
