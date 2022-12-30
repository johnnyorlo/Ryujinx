using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Util;
using System;

namespace Ryujinx.Horizon.Sdk.Mii.Detail
{
    interface IImageDatabaseService : IServiceObject
    {
        Result Initialize(out sbyte arg0, bool arg1);
        Result Reload();
        Result GetCount(out int arg0);
        Result IsEmpty(out bool arg0);
        Result IsFull(out bool arg0);
        Result GetAttribute(out ImageAttributeImpl arg0, int arg1);
        Result LoadImage(Span<byte> arg0, Uuid arg1);
        Result AddOrUpdateImage(out int arg0, sbyte arg1, sbyte arg2, sbyte arg3, Nickname arg4, CreateId arg5, Uuid arg6, ReadOnlySpan<Uuid> arg7, ReadOnlySpan<byte> arg8);
        Result DeleteImages(ReadOnlySpan<Uuid> arg0);
        Result DeleteFile();
        Result DestroyFile();
        Result ImportFile(ReadOnlySpan<byte> arg0);
        Result ExportFile(out long arg0, Span<byte> arg1);
        Result ForceInitialize(out sbyte arg0, bool arg1);
    }
}
