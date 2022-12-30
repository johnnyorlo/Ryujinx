using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class OverlayFunctions : IOverlayFunctions
    {
        [CmifCommand(0)]
        public Result BeginOverlayUserInteraction()
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result EndOverlayUserInteraction()
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetApplicationIdForLogo(out ApplicationId arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result SetGpuTimeSliceBoost(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result SetAutoSleepTimeAndDimmingTimeEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(5)]
        public Result TerminateApplicationAndSetReason(uint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(6)]
        public Result SetScreenShotPermissionGlobally(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(10)]
        public Result StartShutdownSequenceForOverlay()
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result StartRebootSequenceForOverlay()
        {
            return Result.Success;
        }

        [CmifCommand(20)]
        public Result SetHandlingHomeButtonShortPressedEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(21)]
        public Result SetHandlingTouchScreenInputEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(30)]
        public Result SetHealthWarningShowingState(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(31)]
        public Result IsHealthWarningRequired(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(90)]
        public Result SetRequiresGpuResourceUse(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(101)]
        public Result BeginToObserveHidInputForDevelop()
        {
            return Result.Success;
        }
    }
}
