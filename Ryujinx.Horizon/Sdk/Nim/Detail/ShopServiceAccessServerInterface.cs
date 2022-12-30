using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Nim.Detail
{
    class ShopServiceAccessServerInterface : IShopServiceAccessServerInterface
    {
        [CmifCommand(0)]
        public Result CreateServerInterface(out IShopServiceAccessServer arg0, ulong arg1, [CopyHandle] int arg2, ulong arg3, [ClientProcessId] ulong pid)
        {
            arg0 = new ShopServiceAccessServer();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result RefreshDebugAvailability()
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result ClearDebugResponse()
        {
            return Result.Success;
        }

        [CmifCommand(3)]
        public Result RegisterDebugResponse(byte arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<sbyte> arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<sbyte> arg2, uint arg3, uint arg4)
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result IsLargeResourceAvailable(out bool arg0, ulong arg1, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
