using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Ec.Detail
{
    class AsyncData : IAsyncData
    {
        [CmifCommand(0)]
        public Result GetSize(out ulong arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result Get(out ulong arg0, long arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result Cancel()
        {
            return Result.Success;
        }
    }
}
