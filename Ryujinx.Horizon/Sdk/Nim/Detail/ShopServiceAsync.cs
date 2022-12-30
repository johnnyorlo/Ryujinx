using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Err;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Nim.Detail
{
    class ShopServiceAsync : IShopServiceAsync
    {
        [CmifCommand(0)]
        public Result Cancel()
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetSize(out ulong arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result Read(out ulong arg0, ulong arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetErrorCode(out ErrorCode arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result Request()
        {
            return Result.Success;
        }

        [CmifCommand(5)]
        public Result Prepare([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<sbyte> arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<sbyte> arg1)
        {
            return Result.Success;
        }
    }
}
