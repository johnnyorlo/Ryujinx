using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IAppletCommonFunctions : IServiceObject
    {
        Result SetTerminateResult(uint arg0);
        Result ReadThemeStorage(out ulong arg0, ulong arg1, Span<byte> arg2);
        Result WriteThemeStorage(ulong arg0, ReadOnlySpan<byte> arg1);
        Result PushToAppletBoundChannel(IStorage arg0);
        Result TryPopFromAppletBoundChannel(out IStorage arg0);
        Result GetDisplayLogicalResolution(out int arg0, out int arg1);
        Result SetDisplayMagnification(float arg0, float arg1, float arg2, float arg3);
        Result SetHomeButtonDoubleClickEnabled(bool arg0);
        Result GetHomeButtonDoubleClickEnabled(out bool arg0);
        Result IsHomeButtonShortPressedBlocked(out bool arg0);
        Result IsVrModeCurtainRequired(out bool arg0);
        Result IsSleepRequiredByHighTemperature(out bool arg0);
        Result IsSleepRequiredByLowBattery(out bool arg0);
        Result SetCpuBoostRequestPriority(int arg0);
        Result SetHandlingCaptureButtonShortPressedMessageEnabledForApplet(bool arg0);
        Result SetHandlingCaptureButtonLongPressedMessageEnabledForApplet(bool arg0);
    }
}
