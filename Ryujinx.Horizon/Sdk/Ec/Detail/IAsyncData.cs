using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Ec.Detail
{
    interface IAsyncData : IServiceObject
    {
        Result GetSize(out ulong arg0);
        Result Get(out ulong arg0, long arg1, Span<byte> arg2);
        Result Cancel();
    }
}
