using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Nifm.Detail
{
    class ScanRequest : IScanRequest
    {
        [CmifCommand(0)]
        public Result Submit()
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result IsProcessing(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetResult()
        {
            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetSystemEventReadableHandle([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result SetChannels([Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<short> arg0)
        {
            return Result.Success;
        }
    }
}
