using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Ssl.Sf
{
    class SslContext : ISslContext
    {
        [CmifCommand(0)]
        public Result SetOption(ContextOption arg0, int arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetOption(out int arg0, ContextOption arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result CreateConnection(out ISslConnection arg0)
        {
            arg0 = new SslConnection();

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetConnectionCount(out uint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result ImportServerPki(out ulong arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1, CertificateFormat arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(5)]
        public Result ImportClientPki(out ulong arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(6)]
        public Result RemoveServerPki(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(7)]
        public Result RemoveClientPki(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(8)]
        public Result RegisterInternalPki(out ulong arg0, InternalPki arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(9)]
        public Result AddPolicyOid([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(10)]
        public Result ImportCrl(out ulong arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(11)]
        public Result RemoveCrl(ulong arg0)
        {
            return Result.Success;
        }
    }
}
