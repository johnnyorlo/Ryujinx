using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Err.Detail;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Err.Context
{
    interface IWriterForApplication : IServiceObject
    {
        Result CreateContextRegistrar(out IContextRegistrar arg0);
        Result CommitContext(ContextDescriptor arg0, ResultHolder arg1, ReadOnlySpan<byte> arg2, ResultHolder arg3);
    }
}
