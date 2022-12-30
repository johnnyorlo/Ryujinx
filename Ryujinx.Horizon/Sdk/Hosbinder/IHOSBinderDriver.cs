using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Hosbinder
{
    interface IHOSBinderDriver : IServiceObject
    {
        Result TransactParcel(int arg0, uint arg1, ReadOnlySpan<byte> arg2, Span<byte> arg3, uint arg4);
        Result AdjustRefcount(int arg0, int arg1, int arg2);
        Result GetNativeHandle(int arg0, uint arg1, out int arg2);
        Result TransactParcelAuto(int arg0, uint arg1, ReadOnlySpan<byte> arg2, Span<byte> arg3, uint arg4);
    }
}
