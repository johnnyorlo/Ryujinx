using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Ssl.Sf
{
    class SslConnection : ISslConnection
    {
        [CmifCommand(0)]
        public Result SetSocketDescriptor(int arg0, out int arg1)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result SetHostName([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result SetVerifyOption(VerifyOption arg0)
        {
            return Result.Success;
        }

        [CmifCommand(3)]
        public Result SetIoMode(IoMode arg0)
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result GetSocketDescriptor(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(5)]
        public Result GetHostName([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0, out uint arg1)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(6)]
        public Result GetVerifyOption(out VerifyOption arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(7)]
        public Result GetIoMode(out IoMode arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8)]
        public Result DoHandshake()
        {
            return Result.Success;
        }

        [CmifCommand(9)]
        public Result DoHandshakeGetServerCert(out uint arg0, out uint arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result Read(out uint arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(11)]
        public Result Write(out uint arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(12)]
        public Result Pending(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(13)]
        public Result Peek(out uint arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(14)]
        public Result Poll(out PollEvent arg0, PollEvent arg1, uint arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(15)]
        public Result GetVerifyCertError()
        {
            return Result.Success;
        }

        [CmifCommand(16)]
        public Result GetNeededServerCertBufferSize(out uint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(17)]
        public Result SetSessionCacheMode(SessionCacheMode arg0)
        {
            return Result.Success;
        }

        [CmifCommand(18)]
        public Result GetSessionCacheMode(out SessionCacheMode arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(19)]
        public Result FlushSessionCache()
        {
            return Result.Success;
        }

        [CmifCommand(20)]
        public Result SetRenegotiationMode(RenegotiationMode arg0)
        {
            return Result.Success;
        }

        [CmifCommand(21)]
        public Result GetRenegotiationMode(out RenegotiationMode arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(22)]
        public Result SetOption(OptionType arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(23)]
        public Result GetOption(out bool arg0, OptionType arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(24)]
        public Result GetVerifyCertErrors([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0, out uint arg1, out uint arg2)
        {
            arg1 = default;
            arg2 = default;

            return Result.Success;
        }

        [CmifCommand(25)]
        public Result GetCipherInfo(uint arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(26)]
        public Result SetNextAlpnProto([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(27)]
        public Result GetNextAlpnProto(out AlpnProtoState arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1, out uint arg2)
        {
            arg0 = default;
            arg2 = default;

            return Result.Success;
        }
    }
}
