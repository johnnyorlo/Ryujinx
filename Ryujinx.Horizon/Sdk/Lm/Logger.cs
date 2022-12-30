using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Lm
{
    class Logger : ILogger
    {
        [CmifCommand(0)]
        public Result Log([Buffer(HipcBufferFlags.In | HipcBufferFlags.AutoSelect)] ReadOnlySpan<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result SetDestination(uint arg0)
        {
            return Result.Success;
        }
    }
}
