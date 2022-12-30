using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Err;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Nim.Detail
{
    interface IShopServiceAsync : IServiceObject
    {
        Result Cancel();
        Result GetSize(out ulong arg0);
        Result Read(out ulong arg0, ulong arg1, Span<byte> arg2);
        Result GetErrorCode(out ErrorCode arg0);
        Result Request();
        Result Prepare(ReadOnlySpan<sbyte> arg0, ReadOnlySpan<sbyte> arg1);
    }
}
