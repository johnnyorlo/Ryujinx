using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Ngc.T.Detail
{
    class Service : IService
    {
        [CmifCommand(0)]
        public Result Match(out bool arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result Filter([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<sbyte> arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg1)
        {
            return Result.Success;
        }
    }
}
