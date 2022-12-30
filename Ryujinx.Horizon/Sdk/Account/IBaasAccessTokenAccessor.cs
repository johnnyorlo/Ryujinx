using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account.Detail;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Account
{
    interface IBaasAccessTokenAccessor : IServiceObject
    {
        Result EnsureCacheAsync(out IAsyncContext arg0, Uid arg1);
        Result LoadCache(out uint arg0, Span<byte> arg1, Uid arg2);
        Result GetDeviceAccountId(out ulong arg0, Uid arg1);
    }
}
