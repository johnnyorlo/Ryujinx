using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class AppletCommonFunctions : IAppletCommonFunctions
    {
        [CmifCommand(0)]
        public Result SetTerminateResult(uint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(10)]
        public Result ReadThemeStorage(out ulong arg0, ulong arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.AutoSelect)] Span<byte> arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(11)]
        public Result WriteThemeStorage(ulong arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.AutoSelect)] ReadOnlySpan<byte> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(20)]
        public Result PushToAppletBoundChannel(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(21)]
        public Result TryPopFromAppletBoundChannel(out IStorage arg0)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(40)]
        public Result GetDisplayLogicalResolution(out int arg0, out int arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(42)]
        public Result SetDisplayMagnification(float arg0, float arg1, float arg2, float arg3)
        {
            return Result.Success;
        }

        [CmifCommand(50)]
        public Result SetHomeButtonDoubleClickEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(51)]
        public Result GetHomeButtonDoubleClickEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(52)]
        public Result IsHomeButtonShortPressedBlocked(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(60)]
        public Result IsVrModeCurtainRequired(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(61)]
        public Result IsSleepRequiredByHighTemperature(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(62)]
        public Result IsSleepRequiredByLowBattery(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(70)]
        public Result SetCpuBoostRequestPriority(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(80)]
        public Result SetHandlingCaptureButtonShortPressedMessageEnabledForApplet(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(81)]
        public Result SetHandlingCaptureButtonLongPressedMessageEnabledForApplet(bool arg0)
        {
            return Result.Success;
        }
    }
}
