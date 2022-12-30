using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using Ryujinx.Horizon.Sdk.Util;
using System;

namespace Ryujinx.Horizon.Sdk.Mii.Detail
{
    class ImageDatabaseService : IImageDatabaseService
    {
        [CmifCommand(0)]
        public Result Initialize(out sbyte arg0, bool arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result Reload()
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result GetCount(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(12)]
        public Result IsEmpty(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(13)]
        public Result IsFull(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(14)]
        public Result GetAttribute(out ImageAttributeImpl arg0, int arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(15)]
        public Result LoadImage([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0, Uuid arg1)
        {
            return Result.Success;
        }

        [CmifCommand(16)]
        public Result AddOrUpdateImage(out int arg0, sbyte arg1, sbyte arg2, sbyte arg3, Nickname arg4, CreateId arg5, Uuid arg6, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<Uuid> arg7, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg8)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(17)]
        public Result DeleteImages([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<Uuid> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(100)]
        public Result DeleteFile()
        {
            return Result.Success;
        }

        [CmifCommand(101)]
        public Result DestroyFile()
        {
            return Result.Success;
        }

        [CmifCommand(102)]
        public Result ImportFile([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(103)]
        public Result ExportFile(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(104)]
        public Result ForceInitialize(out sbyte arg0, bool arg1)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
