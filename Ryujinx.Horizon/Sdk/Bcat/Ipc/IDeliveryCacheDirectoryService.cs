using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Bcat.Ipc
{
    interface IDeliveryCacheDirectoryService : IServiceObject
    {
        Result Open(DirectoryName arg0);
        Result Read(out int arg0, Span<DeliveryCacheDirectoryEntry> arg1);
        Result GetCount(out int arg0);
    }
}
