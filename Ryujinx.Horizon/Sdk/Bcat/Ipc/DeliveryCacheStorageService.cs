using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Bcat.Ipc
{
    class DeliveryCacheStorageService : IDeliveryCacheStorageService
    {
        [CmifCommand(0)]
        public Result CreateFileService(out IDeliveryCacheFileService arg0)
        {
            arg0 = new DeliveryCacheFileService();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result CreateDirectoryService(out IDeliveryCacheDirectoryService arg0)
        {
            arg0 = new DeliveryCacheDirectoryService();

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result EnumerateDeliveryCacheDirectory(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<DirectoryName> arg1)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
