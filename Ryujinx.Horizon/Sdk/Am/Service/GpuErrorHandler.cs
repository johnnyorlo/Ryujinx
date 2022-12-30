using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class GpuErrorHandler : IGpuErrorHandler
    {
        [CmifCommand(100)]
        public Result GetManualGpuErrorInfoSize(out ulong arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(101)]
        public Result GetManualGpuErrorInfo(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(102)]
        public Result GetManualGpuErrorDetectionSystemEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(103)]
        public Result FinishManualGpuErrorHandling()
        {
            return Result.Success;
        }
    }
}
