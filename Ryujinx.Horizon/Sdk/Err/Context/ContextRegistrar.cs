using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Err.Detail;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Err.Context
{
    class ContextRegistrar : IContextRegistrar
    {
        [CmifCommand(0)]
        public Result Complete(out ContextDescriptor arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1, ResultHolder arg2)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
