using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Capsrv;
using Ryujinx.Horizon.Sdk.Hosbinder;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Grcsrv
{
    class MovieMaker : IMovieMaker
    {
        [CmifCommand(2)]
        public Result CreateVideoProxy(out IHOSBinderDriver arg0)
        {
            arg0 = new HOSBinderDriver();

            return Result.Success;
        }

        [CmifCommand(9)]
        public Result SetAlbumShimLibraryVersion(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(10)]
        public Result OpenOffscreenLayer(out int arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(11)]
        public Result CloseOffscreenLayer(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(20)]
        public Result StartOffscreenRecording(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(21)]
        public Result AbortOffscreenRecording(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(22)]
        public Result RequestOffscreenRecordingFinishReady(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(23)]
        public Result CompleteOffscreenRecordingFinish(ulong arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(24)]
        public Result StartOffscreenRecordingEx(ulong arg0, OffscreenRecordingParameter arg1)
        {
            return Result.Success;
        }

        [CmifCommand(25)]
        public Result CompleteOffscreenRecordingFinishEx0(ulong arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2, int arg3, int arg4)
        {
            return Result.Success;
        }

        [CmifCommand(26)]
        public Result CompleteOffscreenRecordingFinishEx1(out ApplicationAlbumEntry arg0, ulong arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg3, int arg4, int arg5)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(30)]
        public Result GetOffscreenLayerError(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(41)]
        public Result EncodeOffscreenLayerAudioSample(out ulong arg0, ulong arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(50)]
        public Result GetOffscreenLayerRecordingFinishReadyEvent([CopyHandle] out int arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(52)]
        public Result GetOffscreenLayerAudioEncodeReadyEvent([CopyHandle] out int arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
