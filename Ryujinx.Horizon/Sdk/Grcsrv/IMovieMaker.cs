using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Capsrv;
using Ryujinx.Horizon.Sdk.Hosbinder;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Grcsrv
{
    interface IMovieMaker : IServiceObject
    {
        Result CreateVideoProxy(out IHOSBinderDriver arg0);
        Result SetAlbumShimLibraryVersion(ulong arg0);
        Result OpenOffscreenLayer(out int arg0, ulong arg1);
        Result CloseOffscreenLayer(ulong arg0);
        Result StartOffscreenRecording(ulong arg0);
        Result AbortOffscreenRecording(ulong arg0);
        Result RequestOffscreenRecordingFinishReady(ulong arg0);
        Result CompleteOffscreenRecordingFinish(ulong arg0, ReadOnlySpan<byte> arg1);
        Result StartOffscreenRecordingEx(ulong arg0, OffscreenRecordingParameter arg1);
        Result CompleteOffscreenRecordingFinishEx0(ulong arg0, ReadOnlySpan<byte> arg1, ReadOnlySpan<byte> arg2, int arg3, int arg4);
        Result CompleteOffscreenRecordingFinishEx1(out ApplicationAlbumEntry arg0, ulong arg1, ReadOnlySpan<byte> arg2, ReadOnlySpan<byte> arg3, int arg4, int arg5);
        Result GetOffscreenLayerError(ulong arg0);
        Result EncodeOffscreenLayerAudioSample(out ulong arg0, ulong arg1, ReadOnlySpan<byte> arg2);
        Result GetOffscreenLayerRecordingFinishReadyEvent(out int arg0, ulong arg1);
        Result GetOffscreenLayerAudioEncodeReadyEvent(out int arg0, ulong arg1);
    }
}
