using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Ssl.Sf
{
    interface ISslService : IServiceObject
    {
        Result CreateContext(out ISslContext arg0, SslVersion arg1, ulong arg2, ulong pid);
        Result GetContextCount(out uint arg0);
        Result GetCertificates(Span<byte> arg0, out uint arg1, ReadOnlySpan<byte> arg2);
        Result GetCertificateBufSize(out uint arg0, ReadOnlySpan<byte> arg1);
        Result DebugIoctl(Span<byte> arg0, ReadOnlySpan<byte> arg1, ulong arg2);
        Result SetInterfaceVersion(uint arg0);
        Result FlushSessionCache(out uint arg0, ReadOnlySpan<byte> arg1, FlushSessionCacheOptionType arg2);
        Result SetDebugOption(ReadOnlySpan<byte> arg0, DebugOptionType arg1);
        Result GetDebugOption(Span<byte> arg0, DebugOptionType arg1);
        Result ClearTls12FallbackFlag();
    }
}
