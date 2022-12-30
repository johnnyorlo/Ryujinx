using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Ec.Detail;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Ec
{
    class ContentsServiceManager : IContentsServiceManager
    {
        [CmifCommand(0)]
        public Result RequestContentsAuthorizationToken([CopyHandle] out int arg0, out IAsyncData arg1, ulong arg2, Nonce arg3, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg4, [ClientProcessId] ulong pid)
        {
            arg0 = default;
            arg1 = new AsyncData();

            return Result.Success;
        }
    }
}
