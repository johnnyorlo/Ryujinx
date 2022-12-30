using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Ngc.T.Detail
{
    interface IService : IServiceObject
    {
        Result Match(out bool arg0, ReadOnlySpan<sbyte> arg1);
        Result Filter(Span<sbyte> arg0, ReadOnlySpan<sbyte> arg1);
    }
}
