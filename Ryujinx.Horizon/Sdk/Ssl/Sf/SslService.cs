using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Ssl.Sf
{
    class SslService : ISslService
    {
        [CmifCommand(0)]
        public Result CreateContext(out ISslContext arg0, SslVersion arg1, ulong arg2)
        {
            arg0 = new SslContext();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetContextCount(out uint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetCertificates([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0, out uint arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetCertificateBufSize(out uint arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result DebugIoctl([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1, ulong arg2)
        {
            return Result.Success;
        }

        [CmifCommand(5)]
        public Result SetInterfaceVersion(uint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(6)]
        public Result FlushSessionCache(out uint arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1, FlushSessionCacheOptionType arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(7)]
        public Result SetDebugOption([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg0, DebugOptionType arg1)
        {
            return Result.Success;
        }

        [CmifCommand(8)]
        public Result GetDebugOption([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0, DebugOptionType arg1)
        {
            return Result.Success;
        }

        [CmifCommand(9)]
        public Result ClearTls12FallbackFlag()
        {
            return Result.Success;
        }
    }
}
