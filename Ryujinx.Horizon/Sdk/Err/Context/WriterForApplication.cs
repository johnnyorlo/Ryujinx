using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Err.Detail;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Err.Context
{
    class WriterForApplication : IWriterForApplication
    {
        [CmifCommand(0)]
        public Result CreateContextRegistrar(out IContextRegistrar arg0)
        {
            arg0 = new ContextRegistrar();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result CommitContext(ContextDescriptor arg0, ResultHolder arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2, ResultHolder arg3)
        {
            return Result.Success;
        }
    }
}
