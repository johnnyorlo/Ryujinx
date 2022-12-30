using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Ec.Detail;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Ec
{
    interface IContentsServiceManager : IServiceObject
    {
        Result RequestContentsAuthorizationToken(out int arg0, out IAsyncData arg1, ulong arg2, Nonce arg3, ReadOnlySpan<byte> arg4);
    }
}
