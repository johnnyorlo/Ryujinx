using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Bcat.Ipc
{
    class DeliveryCacheFileService : IDeliveryCacheFileService
    {
        [CmifCommand(0)]
        public Result Open(DirectoryName arg0, FileName arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result Read(out ulong arg0, long arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetSize(out long arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetDigest(out Digest arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
