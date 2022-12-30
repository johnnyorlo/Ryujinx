using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Olsc.Srv
{
    class AsyncListData : IAsyncListData
    {
        [CmifCommand(100)]
        public Result GetDataCount(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(101)]
        public Result GetData(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<SaveDataBackupInfo> arg1, int arg2)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
