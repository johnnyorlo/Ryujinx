using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Ssl.Sf
{
    interface ISslConnection : IServiceObject
    {
        Result SetSocketDescriptor(int arg0, out int arg1);
        Result SetHostName(ReadOnlySpan<byte> arg0);
        Result SetVerifyOption(VerifyOption arg0);
        Result SetIoMode(IoMode arg0);
        Result GetSocketDescriptor(out int arg0);
        Result GetHostName(Span<byte> arg0, out uint arg1);
        Result GetVerifyOption(out VerifyOption arg0);
        Result GetIoMode(out IoMode arg0);
        Result DoHandshake();
        Result DoHandshakeGetServerCert(out uint arg0, out uint arg1, Span<byte> arg2);
        Result Read(out uint arg0, Span<byte> arg1);
        Result Write(out uint arg0, ReadOnlySpan<byte> arg1);
        Result Pending(out int arg0);
        Result Peek(out uint arg0, Span<byte> arg1);
        Result Poll(out PollEvent arg0, PollEvent arg1, uint arg2);
        Result GetVerifyCertError();
        Result GetNeededServerCertBufferSize(out uint arg0);
        Result SetSessionCacheMode(SessionCacheMode arg0);
        Result GetSessionCacheMode(out SessionCacheMode arg0);
        Result FlushSessionCache();
        Result SetRenegotiationMode(RenegotiationMode arg0);
        Result GetRenegotiationMode(out RenegotiationMode arg0);
        Result SetOption(OptionType arg0, bool arg1);
        Result GetOption(out bool arg0, OptionType arg1);
        Result GetVerifyCertErrors(Span<byte> arg0, out uint arg1, out uint arg2);
        Result GetCipherInfo(uint arg0, Span<byte> arg1);
        Result SetNextAlpnProto(ReadOnlySpan<byte> arg0);
        Result GetNextAlpnProto(out AlpnProtoState arg0, Span<byte> arg1, out uint arg2);
    }
}
