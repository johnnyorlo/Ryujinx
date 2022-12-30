using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Bcat.Ipc
{
    class DeliveryCacheDirectoryService : IDeliveryCacheDirectoryService
    {
        [CmifCommand(0)]
        public Result Open(DirectoryName arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result Read(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<DeliveryCacheDirectoryEntry> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetCount(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
