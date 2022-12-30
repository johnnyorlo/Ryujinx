using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Codec.Detail
{
    interface IHardwareOpusDecoder : IServiceObject
    {
        Result DecodeInterleavedOld(out int arg0, out int arg1, Span<byte> arg2, ReadOnlySpan<byte> arg3);
        Result SetContext(ReadOnlySpan<byte> arg0);
        Result DecodeInterleavedForMultiStreamOld(out int arg0, out int arg1, Span<byte> arg2, ReadOnlySpan<byte> arg3);
        Result SetContextForMultiStream(ReadOnlySpan<byte> arg0);
        Result DecodeInterleavedWithPerfOld(out int arg0, out long arg1, out int arg2, Span<byte> arg3, ReadOnlySpan<byte> arg4);
        Result DecodeInterleavedForMultiStreamWithPerfOld(out int arg0, out long arg1, out int arg2, Span<byte> arg3, ReadOnlySpan<byte> arg4);
        Result DecodeInterleavedWithPerfAndResetOld(out int arg0, out long arg1, out int arg2, Span<byte> arg3, ReadOnlySpan<byte> arg4, bool arg5);
        Result DecodeInterleavedForMultiStreamWithPerfAndResetOld(out int arg0, out long arg1, out int arg2, Span<byte> arg3, ReadOnlySpan<byte> arg4, bool arg5);
        Result DecodeInterleaved(out int arg0, out long arg1, out int arg2, Span<byte> arg3, ReadOnlySpan<byte> arg4, bool arg5);
        Result DecodeInterleavedForMultiStream(out int arg0, out long arg1, out int arg2, Span<byte> arg3, ReadOnlySpan<byte> arg4, bool arg5);
    }
}
