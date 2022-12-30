using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Jitsrv
{
    class JitEnvironmentBase : IJitEnvironmentBase
    {
        [CmifCommand(1000)]
        public Result LoadPlugin([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1, [CopyHandle] int arg2, ulong arg3)
        {
            return Result.Success;
        }

        [CmifCommand(1001)]
        public Result GetCodeAddress(out ulong arg0, out ulong arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }
    }
}
