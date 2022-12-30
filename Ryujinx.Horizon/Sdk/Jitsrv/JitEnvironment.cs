using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Jit;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Jitsrv
{
    class JitEnvironment : IJitEnvironment
    {
        // Could not determine command ID, please fill it in manually
        public Result GenerateCode(out int arg0, out CodeRange arg1, out CodeRange arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg3, ulong arg4, CodeRange arg5, CodeRange arg6, Struct32 arg7, uint arg8, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg9)
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result Control(out int arg0, ulong arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg3)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
