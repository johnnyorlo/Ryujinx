using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Hosbinder;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using Ryujinx.Horizon.Sdk.Vi;
using System;

namespace Ryujinx.Horizon.Sdk.Visrv.Sf
{
    class ApplicationDisplayService : IApplicationDisplayService
    {
        [CmifCommand(100)]
        public Result GetRelayService(out IHOSBinderDriver arg0)
        {
            arg0 = new HOSBinderDriver();

            return Result.Success;
        }

        [CmifCommand(101)]
        public Result GetSystemDisplayService(out ISystemDisplayService arg0)
        {
            arg0 = new SystemDisplayService();

            return Result.Success;
        }

        [CmifCommand(102)]
        public Result GetManagerDisplayService(out IManagerDisplayService arg0)
        {
            arg0 = new ManagerDisplayService();

            return Result.Success;
        }

        [CmifCommand(103)]
        public Result GetIndirectDisplayTransactionService(out IHOSBinderDriver arg0)
        {
            arg0 = new HOSBinderDriver();

            return Result.Success;
        }

        [CmifCommand(1000)]
        public Result ListDisplays(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<DisplayInfo> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1010)]
        public Result OpenDisplay(out ulong arg0, DisplayName arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1011)]
        public Result OpenDefaultDisplay(out ulong arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1020)]
        public Result CloseDisplay(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1101)]
        public Result SetDisplayEnabled(ulong arg0, bool arg1)
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

        [CmifCommand(2020)]
        public Result OpenLayer(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1, ulong arg2, DisplayName arg3, AppletResourceUserId arg4, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2021)]
        public Result CloseLayer(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2030)]
        public Result CreateStrayLayer(out ulong arg0, out long arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg2, ulong arg3, uint arg4)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(2031)]
        public Result DestroyStrayLayer(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2101)]
        public Result SetLayerScalingMode(ulong arg0, uint arg1)
        {
            return Result.Success;
        }

        [CmifCommand(2102)]
        public Result ConvertScalingMode(out long arg0, uint arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2450)]
        public Result GetIndirectLayerImageMap(out long arg0, out long arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] Span<byte> arg2, long arg3, long arg4, ulong arg5, AppletResourceUserId arg6, [ClientProcessId] ulong pid)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(2451)]
        public Result GetIndirectLayerImageCropMap(out long arg0, out long arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] Span<byte> arg2, long arg3, long arg4, float arg5, float arg6, float arg7, float arg8, ulong arg9, AppletResourceUserId arg10, [ClientProcessId] ulong pid)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(2460)]
        public Result GetIndirectLayerImageRequiredMemoryInfo(out long arg0, out long arg1, long arg2, long arg3)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(5202)]
        public Result GetDisplayVsyncEvent([CopyHandle] out int arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(5203)]
        public Result GetDisplayVsyncEventForDebug([CopyHandle] out int arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
