using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account.Detail;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Account
{
    class BaasAccessTokenAccessor : IBaasAccessTokenAccessor
    {
        [CmifCommand(0)]
        public Result EnsureCacheAsync(out IAsyncContext arg0, Uid arg1)
        {
            arg0 = new AsyncContext();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result LoadCache(out uint arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1, Uid arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetDeviceAccountId(out ulong arg0, Uid arg1)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
