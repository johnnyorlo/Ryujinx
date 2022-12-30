using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class StorageAccessor : IStorageAccessor
    {
        [CmifCommand(0)]
        public Result GetSize(out long arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result Write(long arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.AutoSelect)] ReadOnlySpan<byte> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result Read(long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.AutoSelect)] Span<byte> arg1)
        {
            return Result.Success;
        }
    }
}
