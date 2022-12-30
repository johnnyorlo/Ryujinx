using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using Ryujinx.Horizon.Sdk.Vi;
using Ryujinx.Horizon.Sdk.Vi.Fbshare;
using System;

namespace Ryujinx.Horizon.Sdk.Visrv.Sf
{
    class ManagerDisplayService : IManagerDisplayService
    {
        [CmifCommand(200)]
        public Result AllocateProcessHeapBlock(out ulong arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(201)]
        public Result FreeProcessHeapBlock(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1102)]
        public Result GetDisplayResolution(out long arg0, out long arg1, ulong arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(2010)]
        public Result CreateManagedLayer(out ulong arg0, ulong arg1, uint arg2, AppletResourceUserId arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2011)]
        public Result DestroyManagedLayer(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2012)]
        public Result CreateStrayLayer(out ulong arg0, out long arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg2, ulong arg3, uint arg4)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(2050)]
        public Result CreateIndirectLayer(out ulong arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2051)]
        public Result DestroyIndirectLayer(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2052)]
        public Result CreateIndirectProducerEndPoint(out ulong arg0, ulong arg1, AppletResourceUserId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2053)]
        public Result DestroyIndirectProducerEndPoint(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2054)]
        public Result CreateIndirectConsumerEndPoint(out ulong arg0, ulong arg1, AppletResourceUserId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2055)]
        public Result DestroyIndirectConsumerEndPoint(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2300)]
        public Result AcquireLayerTexturePresentingEvent([CopyHandle] out int arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2301)]
        public Result ReleaseLayerTexturePresentingEvent(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2302)]
        public Result GetDisplayHotplugEvent([CopyHandle] out int arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2303)]
        public Result GetDisplayModeChangedEvent([CopyHandle] out int arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2402)]
        public Result GetDisplayHotplugState(out uint arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2501)]
        public Result GetCompositorErrorInfo([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x1000)] out CompositorError arg0, out int arg1, long arg2, ulong arg3)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(2601)]
        public Result GetDisplayErrorEvent([CopyHandle] out int arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2701)]
        public Result GetDisplayFatalErrorEvent([CopyHandle] out int arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4201)]
        public Result SetDisplayAlpha(ulong arg0, float arg1)
        {
            return Result.Success;
        }

        [CmifCommand(4203)]
        public Result SetDisplayLayerStack(ulong arg0, uint arg1)
        {
            return Result.Success;
        }

        [CmifCommand(4205)]
        public Result SetDisplayPowerState(ulong arg0, uint arg1)
        {
            return Result.Success;
        }

        [CmifCommand(4206)]
        public Result SetDefaultDisplay(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(4207)]
        public Result ResetDisplayPanel(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(4208)]
        public Result SetDisplayFatalErrorEnabled(ulong arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(4209)]
        public Result IsDisplayPanelOn(out bool arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4300)]
        public Result GetInternalPanelId(out byte arg0, out byte arg1, out byte arg2, ulong arg3)
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;

            return Result.Success;
        }

        [CmifCommand(6000)]
        public Result AddToLayerStack(ulong arg0, uint arg1)
        {
            return Result.Success;
        }

        [CmifCommand(6001)]
        public Result RemoveFromLayerStack(ulong arg0, uint arg1)
        {
            return Result.Success;
        }

        [CmifCommand(6002)]
        public Result SetLayerVisibility(ulong arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(6003)]
        public Result SetLayerConfig(ulong arg0, LayerConfig arg1)
        {
            return Result.Success;
        }

        [CmifCommand(6004)]
        public Result AttachLayerPresentationTracer(ulong arg0, uint arg1)
        {
            return Result.Success;
        }

        [CmifCommand(6005)]
        public Result DetachLayerPresentationTracer(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(6006)]
        public Result StartLayerPresentationRecording(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(6007)]
        public Result StopLayerPresentationRecording(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(6008)]
        public Result StartLayerPresentationFenceWait(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(6009)]
        public Result StopLayerPresentationFenceWait(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(6010)]
        public Result GetLayerPresentationAllFencesExpiredEvent([CopyHandle] out int arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(6011)]
        public Result EnableLayerAutoClearTransitionBuffer(ulong arg0, SharedBufferHandle arg1, long arg2, uint arg3, SharedTextureOption arg4)
        {
            return Result.Success;
        }

        [CmifCommand(6012)]
        public Result DisableLayerAutoClearTransitionBuffer(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(6013)]
        public Result SetLayerOpacity(ulong arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(7000)]
        public Result SetContentVisibility(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(8000)]
        public Result SetConductorLayer(ulong arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(8001)]
        public Result SetTimestampTracking(ulong arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(8100)]
        public Result SetIndirectProducerFlipOffset(ulong arg0, ulong arg1, TimeSpan arg2)
        {
            return Result.Success;
        }

        [CmifCommand(8200)]
        public Result CreateSharedBufferStaticStorage(out SharedBufferHandle arg0, ulong arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x188)] SharedMemoryPoolLayout arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8201)]
        public Result CreateSharedBufferTransferMemory(out SharedBufferHandle arg0, [CopyHandle] int arg1, ulong arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x188)] SharedMemoryPoolLayout arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8202)]
        public Result DestroySharedBuffer(SharedBufferHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(8203)]
        public Result BindSharedLowLevelLayerToManagedLayer(ulong arg0, DisplayName arg1, AppletResourceUserId arg2)
        {
            return Result.Success;
        }

        [CmifCommand(8204)]
        public Result BindSharedLowLevelLayerToIndirectLayer(ulong arg0, AppletResourceUserId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(8207)]
        public Result UnbindSharedLowLevelLayer(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(8208)]
        public Result ConnectSharedLowLevelLayerToSharedBuffer(ulong arg0, SharedBufferHandle arg1)
        {
            return Result.Success;
        }

        [CmifCommand(8209)]
        public Result DisconnectSharedLowLevelLayerFromSharedBuffer(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(8210)]
        public Result CreateSharedLayer(out SharedLayerHandle arg0, AppletResourceUserId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8211)]
        public Result DestroySharedLayer(SharedLayerHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(8216)]
        public Result AttachSharedLayerToLowLevelLayer(SharedLayerHandle arg0, ulong arg1, SharedLayerTextureIndexList arg2)
        {
            return Result.Success;
        }

        [CmifCommand(8217)]
        public Result ForceDetachSharedLayerFromLowLevelLayer(SharedLayerHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(8218)]
        public Result StartDetachSharedLayerFromLowLevelLayer(SharedLayerHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(8219)]
        public Result FinishDetachSharedLayerFromLowLevelLayer(SharedLayerHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(8220)]
        public Result GetSharedLayerDetachReadyEvent([CopyHandle] out int arg0, SharedLayerHandle arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8221)]
        public Result GetSharedLowLevelLayerSynchronizedEvent([CopyHandle] out int arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8222)]
        public Result CheckSharedLowLevelLayerSynchronized(out long arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8223)]
        public Result RegisterSharedBufferImporterAruid(SharedBufferHandle arg0, AppletResourceUserId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(8224)]
        public Result UnregisterSharedBufferImporterAruid(SharedBufferHandle arg0, AppletResourceUserId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(8227)]
        public Result CreateSharedBufferProcessHeap(out SharedBufferHandle arg0, ulong arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x188)] SharedMemoryPoolLayout arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8228)]
        public Result GetSharedLayerLayerStacks(out uint arg0, SharedLayerHandle arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8229)]
        public Result SetSharedLayerLayerStacks(SharedLayerHandle arg0, uint arg1)
        {
            return Result.Success;
        }

        [CmifCommand(8291)]
        public Result PresentDetachedSharedFrameBufferToLowLevelLayer(SharedBufferHandle arg0, ulong arg1, long arg2)
        {
            return Result.Success;
        }

        [CmifCommand(8292)]
        public Result FillDetachedSharedFrameBufferColor(SharedBufferHandle arg0, long arg1, uint arg2, SharedTextureOption arg3)
        {
            return Result.Success;
        }

        [CmifCommand(8293)]
        public Result GetDetachedSharedFrameBufferImage(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1, SharedBufferHandle arg2, long arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8294)]
        public Result SetDetachedSharedFrameBufferImage(SharedBufferHandle arg0, long arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2, SharedTextureOption arg3, uint arg4)
        {
            return Result.Success;
        }

        [CmifCommand(8295)]
        public Result CopyDetachedSharedFrameBufferImage(SharedBufferHandle arg0, long arg1, SharedBufferHandle arg2, long arg3, SharedTextureOption arg4, uint arg5, uint arg6)
        {
            return Result.Success;
        }

        [CmifCommand(8296)]
        public Result SetDetachedSharedFrameBufferSubImage(SharedBufferHandle arg0, long arg1, int arg2, int arg3, int arg4, int arg5, uint arg6, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] ReadOnlySpan<byte> arg7, SharedTextureOption arg8, uint arg9)
        {
            return Result.Success;
        }

        [CmifCommand(8297)]
        public Result GetSharedFrameBufferContentParameter(out uint arg0, out CropRegion arg1, out int arg2, out uint arg3, out int arg4, SharedBufferHandle arg5, long arg6)
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            arg3 = default;
            arg4 = default;

            return Result.Success;
        }

        [CmifCommand(8298)]
        public Result ExpandStartupLogoOnSharedFrameBuffer(SharedBufferHandle arg0, long arg1, SharedTextureOption arg2)
        {
            return Result.Success;
        }
    }
}
