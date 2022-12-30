using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Jit;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Jitsrv
{
    interface IJitEnvironment : IServiceObject
    {
        Result GenerateCode(out int arg0, out CodeRange arg1, out CodeRange arg2, ReadOnlySpan<byte> arg3, ulong arg4, CodeRange arg5, CodeRange arg6, Struct32 arg7, uint arg8, Span<byte> arg9);
        Result Control(out int arg0, ulong arg1, ReadOnlySpan<byte> arg2, Span<byte> arg3);
    }
}
