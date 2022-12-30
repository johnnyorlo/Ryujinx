using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using Ryujinx.Horizon.Sdk.Vi.Fbshare;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class SelfController : ISelfController
    {
        [CmifCommand(0)]
        public Result Exit()
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result LockExit()
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result UnlockExit()
        {
            return Result.Success;
        }

        [CmifCommand(3)]
        public Result EnterFatalSection()
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result LeaveFatalSection()
        {
            return Result.Success;
        }

        [CmifCommand(9)]
        public Result GetLibraryAppletLaunchableEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result SetScreenShotPermission(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result SetOperationModeChangedNotification(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(12)]
        public Result SetPerformanceModeChangedNotification(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(13)]
        public Result SetFocusHandlingMode(bool arg0, bool arg1, bool arg2)
        {
            return Result.Success;
        }

        [CmifCommand(14)]
        public Result SetRestartMessageEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(15)]
        public Result SetScreenShotAppletIdentityInfo(AppletIdentityInfo arg0)
        {
            return Result.Success;
        }

        [CmifCommand(16)]
        public Result SetOutOfFocusSuspendingEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(17)]
        public Result SetControllerFirmwareUpdateSection(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(18)]
        public Result SetRequiresCaptureButtonShortPressedMessage(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(19)]
        public Result SetAlbumImageOrientation(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(20)]
        public Result SetDesirableKeyboardLayout(uint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(21)]
        public Result GetScreenShotProgramId(out ulong arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(40)]
        public Result CreateManagedDisplayLayer(out ulong arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(41)]
        public Result IsSystemBufferSharingEnabled()
        {
            return Result.Success;
        }

        [CmifCommand(42)]
        public Result GetSystemSharedLayerHandle(out SharedBufferHandle arg0, out SharedLayerHandle arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(43)]
        public Result GetSystemSharedBufferHandle(out SharedBufferHandle arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(44)]
        public Result CreateManagedDisplaySeparableLayer(out ulong arg0, out ulong arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(45)]
        public Result SetManagedDisplayLayerSeparationMode(uint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(46)]
        public Result SetRecordingLayerCompositionEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(50)]
        public Result SetHandlesRequestToDisplay(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(51)]
        public Result ApproveToDisplay()
        {
            return Result.Success;
        }

        [CmifCommand(60)]
        public Result OverrideAutoSleepTimeAndDimmingTime(int arg0, int arg1, int arg2, int arg3)
        {
            return Result.Success;
        }

        [CmifCommand(61)]
        public Result SetMediaPlaybackState(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(62)]
        public Result SetIdleTimeDetectionExtension(uint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(63)]
        public Result GetIdleTimeDetectionExtension(out uint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(64)]
        public Result SetInputDetectionSourceSet(uint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(65)]
        public Result ReportUserIsActive()
        {
            return Result.Success;
        }

        [CmifCommand(66)]
        public Result GetCurrentIlluminance(out float arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(67)]
        public Result IsIlluminanceAvailable(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(68)]
        public Result SetAutoSleepDisabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(69)]
        public Result IsAutoSleepDisabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(70)]
        public Result ReportMultimediaError(uint arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(71)]
        public Result GetCurrentIlluminanceEx(out float arg0, out bool arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(72)]
        public Result SetInputDetectionPolicy(InputDetectionPolicy arg0)
        {
            return Result.Success;
        }

        [CmifCommand(80)]
        public Result SetWirelessPriorityMode(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(90)]
        public Result GetAccumulatedSuspendedTickValue(out long arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(91)]
        public Result GetAccumulatedSuspendedTickChangedEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(100)]
        public Result SetAlbumImageTakenNotificationEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(110)]
        public Result SetApplicationAlbumUserData([Buffer(HipcBufferFlags.In | HipcBufferFlags.AutoSelect)] ReadOnlySpan<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(120)]
        public Result SaveCurrentScreenshot(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(130)]
        public Result SetRecordVolumeMuted(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1000)]
        public Result GetDebugStorageChannel(out IStorageChannel arg0)
        {
            arg0 = new StorageChannel();

            return Result.Success;
        }
    }
}
