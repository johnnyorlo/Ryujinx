using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Ssl.Sf
{
    interface ISslContext : IServiceObject
    {
        Result SetOption(ContextOption arg0, int arg1);
        Result GetOption(out int arg0, ContextOption arg1);
        Result CreateConnection(out ISslConnection arg0);
        Result GetConnectionCount(out uint arg0);
        Result ImportServerPki(out ulong arg0, ReadOnlySpan<byte> arg1, CertificateFormat arg2);
        Result ImportClientPki(out ulong arg0, ReadOnlySpan<byte> arg1, ReadOnlySpan<byte> arg2);
        Result RemoveServerPki(ulong arg0);
        Result RemoveClientPki(ulong arg0);
        Result RegisterInternalPki(out ulong arg0, InternalPki arg1);
        Result AddPolicyOid(ReadOnlySpan<byte> arg0);
        Result ImportCrl(out ulong arg0, ReadOnlySpan<byte> arg1);
        Result RemoveCrl(ulong arg0);
    }
}
