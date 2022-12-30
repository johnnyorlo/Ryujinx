using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Vi.Fbshare;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface ISelfController : IServiceObject
    {
        Result Exit();
        Result LockExit();
        Result UnlockExit();
        Result EnterFatalSection();
        Result LeaveFatalSection();
        Result GetLibraryAppletLaunchableEvent(out int arg0);
        Result SetScreenShotPermission(int arg0);
        Result SetOperationModeChangedNotification(bool arg0);
        Result SetPerformanceModeChangedNotification(bool arg0);
        Result SetFocusHandlingMode(bool arg0, bool arg1, bool arg2);
        Result SetRestartMessageEnabled(bool arg0);
        Result SetScreenShotAppletIdentityInfo(AppletIdentityInfo arg0);
        Result SetOutOfFocusSuspendingEnabled(bool arg0);
        Result SetControllerFirmwareUpdateSection(bool arg0);
        Result SetRequiresCaptureButtonShortPressedMessage(bool arg0);
        Result SetAlbumImageOrientation(int arg0);
        Result SetDesirableKeyboardLayout(uint arg0);
        Result GetScreenShotProgramId(out ulong arg0);
        Result CreateManagedDisplayLayer(out ulong arg0);
        Result IsSystemBufferSharingEnabled();
        Result GetSystemSharedLayerHandle(out SharedBufferHandle arg0, out SharedLayerHandle arg1);
        Result GetSystemSharedBufferHandle(out SharedBufferHandle arg0);
        Result CreateManagedDisplaySeparableLayer(out ulong arg0, out ulong arg1);
        Result SetManagedDisplayLayerSeparationMode(uint arg0);
        Result SetRecordingLayerCompositionEnabled(bool arg0);
        Result SetHandlesRequestToDisplay(bool arg0);
        Result ApproveToDisplay();
        Result OverrideAutoSleepTimeAndDimmingTime(int arg0, int arg1, int arg2, int arg3);
        Result SetMediaPlaybackState(bool arg0);
        Result SetIdleTimeDetectionExtension(uint arg0);
        Result GetIdleTimeDetectionExtension(out uint arg0);
        Result SetInputDetectionSourceSet(uint arg0);
        Result ReportUserIsActive();
        Result GetCurrentIlluminance(out float arg0);
        Result IsIlluminanceAvailable(out bool arg0);
        Result SetAutoSleepDisabled(bool arg0);
        Result IsAutoSleepDisabled(out bool arg0);
        Result ReportMultimediaError(uint arg0, ReadOnlySpan<byte> arg1);
        Result GetCurrentIlluminanceEx(out float arg0, out bool arg1);
        Result SetInputDetectionPolicy(InputDetectionPolicy arg0);
        Result SetWirelessPriorityMode(int arg0);
        Result GetAccumulatedSuspendedTickValue(out long arg0);
        Result GetAccumulatedSuspendedTickChangedEvent(out int arg0);
        Result SetAlbumImageTakenNotificationEnabled(bool arg0);
        Result SetApplicationAlbumUserData(ReadOnlySpan<byte> arg0);
        Result SaveCurrentScreenshot(int arg0);
        Result SetRecordVolumeMuted(bool arg0);
        Result GetDebugStorageChannel(out IStorageChannel arg0);
    }
}
