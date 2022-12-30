using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Bcat.Ipc
{
    interface IDeliveryCacheStorageService : IServiceObject
    {
        Result CreateFileService(out IDeliveryCacheFileService arg0);
        Result CreateDirectoryService(out IDeliveryCacheDirectoryService arg0);
        Result EnumerateDeliveryCacheDirectory(out int arg0, Span<DirectoryName> arg1);
    }
}
