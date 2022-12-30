using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Dp2hdmi.Detail;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Vi;
using Ryujinx.Horizon.Sdk.Vi.Fbshare;
using Ryujinx.Horizon.Sdk.Vi.Native;
using System;

namespace Ryujinx.Horizon.Sdk.Visrv.Sf
{
    interface ISystemDisplayService : IServiceObject
    {
        Result GetZOrderCountMin(out long arg0, ulong arg1);
        Result GetZOrderCountMax(out long arg0, ulong arg1);
        Result GetDisplayLogicalResolution(out int arg0, out int arg1, ulong arg2);
        Result SetDisplayMagnification(ulong arg0, int arg1, int arg2, int arg3, int arg4);
        Result SetLayerPosition(ulong arg0, float arg1, float arg2);
        Result SetLayerSize(ulong arg0, long arg1, long arg2);
        Result GetLayerZ(out long arg0, ulong arg1);
        Result SetLayerZ(ulong arg0, long arg1);
        Result SetLayerVisibility(ulong arg0, bool arg1);
        Result SetLayerAlpha(ulong arg0, float arg1);
        Result OpenIndirectLayer(out long arg0, Span<byte> arg1, ulong arg2, AppletResourceUserId arg3, ulong pid);
        Result CloseIndirectLayer(ulong arg0);
        Result FlipIndirectLayer(ulong arg0);
        Result ListDisplayModes(out long arg0, Span<DisplayModeInfo> arg1, ulong arg2);
        Result ListDisplayRgbRanges(out long arg0, Span<uint> arg1, ulong arg2);
        Result ListDisplayContentTypes(out long arg0, Span<uint> arg1, ulong arg2);
        Result GetDisplayMode(out DisplayModeInfo arg0, ulong arg1);
        Result SetDisplayMode(ulong arg0, DisplayModeInfo arg1);
        Result GetDisplayUnderscan(out long arg0, ulong arg1);
        Result SetDisplayUnderscan(ulong arg0, long arg1);
        Result GetDisplayContentType(out uint arg0, ulong arg1);
        Result SetDisplayContentType(ulong arg0, uint arg1);
        Result GetDisplayRgbRange(out uint arg0, ulong arg1);
        Result SetDisplayRgbRange(ulong arg0, uint arg1);
        Result GetDisplayCmuMode(out uint arg0, ulong arg1);
        Result SetDisplayCmuMode(ulong arg0, uint arg1);
        Result GetDisplayContrastRatio(out float arg0, ulong arg1);
        Result SetDisplayContrastRatio(ulong arg0, float arg1);
        Result GetDisplayGamma(out float arg0, ulong arg1);
        Result SetDisplayGamma(ulong arg0, float arg1);
        Result GetDisplayCmuLuma(out float arg0, ulong arg1);
        Result SetDisplayCmuLuma(ulong arg0, float arg1);
        Result SetDisplayCrcMode(ulong arg0, byte arg1);
        Result GetLayerPresentationSubmissionTimestamps(out ulong arg0, out uint arg1, uint arg2, Span<long> arg3);
        Result GetSharedBufferMemoryHandleId(out NativeMemoryHandleId arg0, out ulong arg1, out SharedMemoryPoolLayout arg2, SharedBufferHandle arg3, AppletResourceUserId arg4, ulong pid);
        Result OpenSharedLayer(SharedLayerHandle arg0, AppletResourceUserId arg1, ulong pid);
        Result CloseSharedLayer(SharedLayerHandle arg0);
        Result ConnectSharedLayer(SharedLayerHandle arg0);
        Result DisconnectSharedLayer(SharedLayerHandle arg0);
        Result AcquireSharedFrameBuffer(out long arg0, out NativeSync arg1, out SharedLayerTextureIndexList arg2, SharedLayerHandle arg3);
        Result PresentSharedFrameBuffer(SharedLayerHandle arg0, long arg1, NativeSync arg2, CropRegion arg3, uint arg4, int arg5);
        Result GetSharedFrameBufferAcquirableEvent(out int arg0, SharedLayerHandle arg1);
        Result FillSharedFrameBufferColor(SharedLayerHandle arg0, long arg1, int arg2, int arg3, int arg4, int arg5);
        Result CancelSharedFrameBuffer(SharedLayerHandle arg0, long arg1);
        Result GetDp2hdmiController(out IDp2hdmiController arg0);
    }
}
