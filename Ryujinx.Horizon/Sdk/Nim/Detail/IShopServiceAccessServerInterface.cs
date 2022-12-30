using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Nim.Detail
{
    interface IShopServiceAccessServerInterface : IServiceObject
    {
        Result CreateServerInterface(out IShopServiceAccessServer arg0, ulong arg1, int arg2, ulong arg3);
        Result RefreshDebugAvailability();
        Result ClearDebugResponse();
        Result RegisterDebugResponse(byte arg0, ReadOnlySpan<sbyte> arg1, ReadOnlySpan<sbyte> arg2, uint arg3, uint arg4);
        Result IsLargeResourceAvailable(out bool arg0, ulong arg1);
    }
}
