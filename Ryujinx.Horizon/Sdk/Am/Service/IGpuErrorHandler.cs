using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IGpuErrorHandler : IServiceObject
    {
        Result GetManualGpuErrorInfoSize(out ulong arg0);
        Result GetManualGpuErrorInfo(out ulong arg0, Span<byte> arg1);
        Result GetManualGpuErrorDetectionSystemEvent(out int arg0);
        Result FinishManualGpuErrorHandling();
    }
}
