using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Hosbinder
{
    class HOSBinderDriver : IHOSBinderDriver
    {
        // Could not determine command ID, please fill it in manually
        public Result TransactParcel(int arg0, uint arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg3, uint arg4)
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result AdjustRefcount(int arg0, int arg1, int arg2)
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetNativeHandle(int arg0, uint arg1, [CopyHandle] out int arg2)
        {
            arg2 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result TransactParcelAuto(int arg0, uint arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.AutoSelect)] ReadOnlySpan<byte> arg2, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.AutoSelect)] Span<byte> arg3, uint arg4)
        {
            return Result.Success;
        }
    }
}
