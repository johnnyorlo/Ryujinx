using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Lm
{
    class LogGetter : ILogGetter
    {
        [CmifCommand(0)]
        public Result StartLogging()
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result StopLogging()
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetLog([Buffer(HipcBufferFlags.Out | HipcBufferFlags.AutoSelect)] Span<byte> arg0, out long arg1, out uint arg2)
        {
            arg1 = default;
            arg2 = default;

            return Result.Success;
        }
    }
}
