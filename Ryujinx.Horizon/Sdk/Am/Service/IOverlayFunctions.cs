using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IOverlayFunctions : IServiceObject
    {
        Result BeginOverlayUserInteraction();
        Result EndOverlayUserInteraction();
        Result GetApplicationIdForLogo(out ApplicationId arg0);
        Result SetGpuTimeSliceBoost(ulong arg0);
        Result SetAutoSleepTimeAndDimmingTimeEnabled(bool arg0);
        Result TerminateApplicationAndSetReason(uint arg0);
        Result SetScreenShotPermissionGlobally(bool arg0);
        Result StartShutdownSequenceForOverlay();
        Result StartRebootSequenceForOverlay();
        Result SetHandlingHomeButtonShortPressedEnabled(bool arg0);
        Result SetHandlingTouchScreenInputEnabled(bool arg0);
        Result SetHealthWarningShowingState(bool arg0);
        Result IsHealthWarningRequired(out bool arg0);
        Result SetRequiresGpuResourceUse(bool arg0);
        Result BeginToObserveHidInputForDevelop();
    }
}
