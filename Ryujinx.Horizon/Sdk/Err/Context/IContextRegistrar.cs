using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Err.Detail;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Err.Context
{
    interface IContextRegistrar : IServiceObject
    {
        Result Complete(out ContextDescriptor arg0, ReadOnlySpan<byte> arg1, ResultHolder arg2);
    }
}
