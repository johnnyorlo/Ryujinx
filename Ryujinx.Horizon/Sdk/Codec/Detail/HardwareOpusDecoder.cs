using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Codec.Detail
{
    class HardwareOpusDecoder : IHardwareOpusDecoder
    {
        [CmifCommand(0)]
        public Result DecodeInterleavedOld(out int arg0, out int arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg3)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result SetContext([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result DecodeInterleavedForMultiStreamOld(out int arg0, out int arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg3)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result SetContextForMultiStream([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result DecodeInterleavedWithPerfOld(out int arg0, out long arg1, out int arg2, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] Span<byte> arg3, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg4)
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;

            return Result.Success;
        }

        [CmifCommand(5)]
        public Result DecodeInterleavedForMultiStreamWithPerfOld(out int arg0, out long arg1, out int arg2, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] Span<byte> arg3, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg4)
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;

            return Result.Success;
        }

        [CmifCommand(6)]
        public Result DecodeInterleavedWithPerfAndResetOld(out int arg0, out long arg1, out int arg2, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] Span<byte> arg3, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg4, bool arg5)
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;

            return Result.Success;
        }

        [CmifCommand(7)]
        public Result DecodeInterleavedForMultiStreamWithPerfAndResetOld(out int arg0, out long arg1, out int arg2, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] Span<byte> arg3, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg4, bool arg5)
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;

            return Result.Success;
        }

        [CmifCommand(8)]
        public Result DecodeInterleaved(out int arg0, out long arg1, out int arg2, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] Span<byte> arg3, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] ReadOnlySpan<byte> arg4, bool arg5)
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;

            return Result.Success;
        }

        [CmifCommand(9)]
        public Result DecodeInterleavedForMultiStream(out int arg0, out long arg1, out int arg2, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] Span<byte> arg3, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] ReadOnlySpan<byte> arg4, bool arg5)
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;

            return Result.Success;
        }
    }
}
