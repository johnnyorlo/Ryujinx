using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Bcat.Ipc
{
    interface IDeliveryCacheFileService : IServiceObject
    {
        Result Open(DirectoryName arg0, FileName arg1);
        Result Read(out ulong arg0, long arg1, Span<byte> arg2);
        Result GetSize(out long arg0);
        Result GetDigest(out Digest arg0);
    }
}
