using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class CommonStateGetter : ICommonStateGetter
    {
        [CmifCommand(0)]
        public Result GetEventHandle([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result ReceiveMessage(out AppletMessage arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetThisAppletKind(out AppletKind arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result AllowToEnterSleep()
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result DisallowToEnterSleep()
        {
            return Result.Success;
        }

        [CmifCommand(5)]
        public Result GetOperationMode(out byte arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(6)]
        public Result GetPerformanceMode(out uint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(7)]
        public Result GetCradleStatus(out byte arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8)]
        public Result GetBootMode(out byte arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(9)]
        public Result GetCurrentFocusState(out byte arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result RequestToAcquireSleepLock()
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result ReleaseSleepLock()
        {
            return Result.Success;
        }

        [CmifCommand(12)]
        public Result ReleaseSleepLockTransiently()
        {
            return Result.Success;
        }

        [CmifCommand(13)]
        public Result GetAcquiredSleepLockEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(14)]
        public Result GetWakeupCount(out ulong arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20)]
        public Result PushToGeneralChannel(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(30)]
        public Result GetHomeButtonReaderLockAccessor(out ILockAccessor arg0)
        {
            arg0 = new LockAccessor();

            return Result.Success;
        }

        [CmifCommand(31)]
        public Result GetReaderLockAccessorEx(out ILockAccessor arg0, int arg1)
        {
            arg0 = new LockAccessor();

            return Result.Success;
        }

        [CmifCommand(32)]
        public Result GetWriterLockAccessorEx(out ILockAccessor arg0, int arg1)
        {
            arg0 = new LockAccessor();

            return Result.Success;
        }

        [CmifCommand(40)]
        public Result GetCradleFwVersion(out uint arg0, out uint arg1, out uint arg2, out uint arg3)
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            arg3 = default;

            return Result.Success;
        }

        [CmifCommand(50)]
        public Result IsVrModeEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(51)]
        public Result SetVrModeEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(52)]
        public Result SetLcdBacklighOffEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(53)]
        public Result BeginVrModeEx()
        {
            return Result.Success;
        }

        [CmifCommand(54)]
        public Result EndVrModeEx()
        {
            return Result.Success;
        }

        [CmifCommand(55)]
        public Result IsInControllerFirmwareUpdateSection(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(59)]
        public Result SetVrPositionForDebug(int arg0, int arg1, int arg2, int arg3)
        {
            return Result.Success;
        }

        [CmifCommand(60)]
        public Result GetDefaultDisplayResolution(out int arg0, out int arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(61)]
        public Result GetDefaultDisplayResolutionChangeEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(62)]
        public Result GetHdcpAuthenticationState(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(63)]
        public Result GetHdcpAuthenticationStateChangeEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(64)]
        public Result SetTvPowerStateMatchingMode(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(65)]
        public Result GetApplicationIdByContentActionName(out ulong arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<sbyte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(66)]
        public Result SetCpuBoostMode(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(67)]
        public Result CancelCpuBoostMode()
        {
            return Result.Success;
        }

        [CmifCommand(68)]
        public Result GetBuiltInDisplayType(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(80)]
        public Result PerformSystemButtonPressingIfInFocus(SystemButtonType arg0)
        {
            return Result.Success;
        }

        [CmifCommand(90)]
        public Result SetPerformanceConfigurationChangedNotification(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(91)]
        public Result GetCurrentPerformanceConfiguration(out uint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(100)]
        public Result SetHandlingHomeButtonShortPressedEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(110)]
        public Result OpenMyGpuErrorHandler(out IGpuErrorHandler arg0)
        {
            arg0 = new GpuErrorHandler();

            return Result.Success;
        }

        [CmifCommand(120)]
        public Result GetAppletLaunchedHistory(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<uint> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(200)]
        public Result GetOperationModeSystemInfo(out uint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(300)]
        public Result GetSettingsPlatformRegion(out byte arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(400)]
        public Result ActivateMigrationService()
        {
            return Result.Success;
        }

        [CmifCommand(401)]
        public Result DeactivateMigrationService()
        {
            return Result.Success;
        }

        [CmifCommand(500)]
        public Result RestrictPowerOperationForSecureLaunchMode()
        {
            return Result.Success;
        }

        [CmifCommand(501)]
        public Result SuppressDisablingSleepTemporarily(TimeSpanType arg0)
        {
            return Result.Success;
        }

        [CmifCommand(502)]
        public Result IsSleepEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(503)]
        public Result IsDisablingSleepSuppressed(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(900)]
        public Result SetRequestExitToLibraryAppletAtExecuteNextProgramEnabled()
        {
            return Result.Success;
        }
    }
}
