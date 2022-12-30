using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Dp2hdmi.Detail;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using Ryujinx.Horizon.Sdk.Vi;
using Ryujinx.Horizon.Sdk.Vi.Fbshare;
using Ryujinx.Horizon.Sdk.Vi.Native;
using System;

namespace Ryujinx.Horizon.Sdk.Visrv.Sf
{
    class SystemDisplayService : ISystemDisplayService
    {
        [CmifCommand(1200)]
        public Result GetZOrderCountMin(out long arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1202)]
        public Result GetZOrderCountMax(out long arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1203)]
        public Result GetDisplayLogicalResolution(out int arg0, out int arg1, ulong arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(1204)]
        public Result SetDisplayMagnification(ulong arg0, int arg1, int arg2, int arg3, int arg4)
        {
            return Result.Success;
        }

        [CmifCommand(2201)]
        public Result SetLayerPosition(ulong arg0, float arg1, float arg2)
        {
            return Result.Success;
        }

        [CmifCommand(2203)]
        public Result SetLayerSize(ulong arg0, long arg1, long arg2)
        {
            return Result.Success;
        }

        [CmifCommand(2204)]
        public Result GetLayerZ(out long arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2205)]
        public Result SetLayerZ(ulong arg0, long arg1)
        {
            return Result.Success;
        }

        [CmifCommand(2207)]
        public Result SetLayerVisibility(ulong arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(2209)]
        public Result SetLayerAlpha(ulong arg0, float arg1)
        {
            return Result.Success;
        }

        [CmifCommand(2400)]
        public Result OpenIndirectLayer(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1, ulong arg2, AppletResourceUserId arg3, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2401)]
        public Result CloseIndirectLayer(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2402)]
        public Result FlipIndirectLayer(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(3000)]
        public Result ListDisplayModes(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<DisplayModeInfo> arg1, ulong arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3001)]
        public Result ListDisplayRgbRanges(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<uint> arg1, ulong arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3002)]
        public Result ListDisplayContentTypes(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<uint> arg1, ulong arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3200)]
        public Result GetDisplayMode(out DisplayModeInfo arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3201)]
        public Result SetDisplayMode(ulong arg0, DisplayModeInfo arg1)
        {
            return Result.Success;
        }

        [CmifCommand(3202)]
        public Result GetDisplayUnderscan(out long arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3203)]
        public Result SetDisplayUnderscan(ulong arg0, long arg1)
        {
            return Result.Success;
        }

        [CmifCommand(3204)]
        public Result GetDisplayContentType(out uint arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3205)]
        public Result SetDisplayContentType(ulong arg0, uint arg1)
        {
            return Result.Success;
        }

        [CmifCommand(3206)]
        public Result GetDisplayRgbRange(out uint arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3207)]
        public Result SetDisplayRgbRange(ulong arg0, uint arg1)
        {
            return Result.Success;
        }

        [CmifCommand(3208)]
        public Result GetDisplayCmuMode(out uint arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3209)]
        public Result SetDisplayCmuMode(ulong arg0, uint arg1)
        {
            return Result.Success;
        }

        [CmifCommand(3210)]
        public Result GetDisplayContrastRatio(out float arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3211)]
        public Result SetDisplayContrastRatio(ulong arg0, float arg1)
        {
            return Result.Success;
        }

        [CmifCommand(3214)]
        public Result GetDisplayGamma(out float arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3215)]
        public Result SetDisplayGamma(ulong arg0, float arg1)
        {
            return Result.Success;
        }

        [CmifCommand(3216)]
        public Result GetDisplayCmuLuma(out float arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3217)]
        public Result SetDisplayCmuLuma(ulong arg0, float arg1)
        {
            return Result.Success;
        }

        [CmifCommand(3218)]
        public Result SetDisplayCrcMode(ulong arg0, byte arg1)
        {
            return Result.Success;
        }

        [CmifCommand(6013)]
        public Result GetLayerPresentationSubmissionTimestamps(out ulong arg0, out uint arg1, uint arg2, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<long> arg3)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(8225)]
        public Result GetSharedBufferMemoryHandleId(out NativeMemoryHandleId arg0, out ulong arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x188)] out SharedMemoryPoolLayout arg2, SharedBufferHandle arg3, AppletResourceUserId arg4, [ClientProcessId] ulong pid)
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;

            return Result.Success;
        }

        [CmifCommand(8250)]
        public Result OpenSharedLayer(SharedLayerHandle arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(8251)]
        public Result CloseSharedLayer(SharedLayerHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(8252)]
        public Result ConnectSharedLayer(SharedLayerHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(8253)]
        public Result DisconnectSharedLayer(SharedLayerHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(8254)]
        public Result AcquireSharedFrameBuffer(out long arg0, out NativeSync arg1, out SharedLayerTextureIndexList arg2, SharedLayerHandle arg3)
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;

            return Result.Success;
        }

        [CmifCommand(8255)]
        public Result PresentSharedFrameBuffer(SharedLayerHandle arg0, long arg1, NativeSync arg2, CropRegion arg3, uint arg4, int arg5)
        {
            return Result.Success;
        }

        [CmifCommand(8256)]
        public Result GetSharedFrameBufferAcquirableEvent([CopyHandle] out int arg0, SharedLayerHandle arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8257)]
        public Result FillSharedFrameBufferColor(SharedLayerHandle arg0, long arg1, int arg2, int arg3, int arg4, int arg5)
        {
            return Result.Success;
        }

        [CmifCommand(8258)]
        public Result CancelSharedFrameBuffer(SharedLayerHandle arg0, long arg1)
        {
            return Result.Success;
        }

        [CmifCommand(9000)]
        public Result GetDp2hdmiController(out IDp2hdmiController arg0)
        {
            arg0 = new Dp2hdmiController();

            return Result.Success;
        }
    }
}
