using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface ICommonStateGetter : IServiceObject
    {
        Result GetEventHandle(out int arg0);
        Result ReceiveMessage(out AppletMessage arg0);
        Result GetThisAppletKind(out AppletKind arg0);
        Result AllowToEnterSleep();
        Result DisallowToEnterSleep();
        Result GetOperationMode(out byte arg0);
        Result GetPerformanceMode(out uint arg0);
        Result GetCradleStatus(out byte arg0);
        Result GetBootMode(out byte arg0);
        Result GetCurrentFocusState(out byte arg0);
        Result RequestToAcquireSleepLock();
        Result ReleaseSleepLock();
        Result ReleaseSleepLockTransiently();
        Result GetAcquiredSleepLockEvent(out int arg0);
        Result GetWakeupCount(out ulong arg0);
        Result PushToGeneralChannel(IStorage arg0);
        Result GetHomeButtonReaderLockAccessor(out ILockAccessor arg0);
        Result GetReaderLockAccessorEx(out ILockAccessor arg0, int arg1);
        Result GetWriterLockAccessorEx(out ILockAccessor arg0, int arg1);
        Result GetCradleFwVersion(out uint arg0, out uint arg1, out uint arg2, out uint arg3);
        Result IsVrModeEnabled(out bool arg0);
        Result SetVrModeEnabled(bool arg0);
        Result SetLcdBacklighOffEnabled(bool arg0);
        Result BeginVrModeEx();
        Result EndVrModeEx();
        Result IsInControllerFirmwareUpdateSection(out bool arg0);
        Result SetVrPositionForDebug(int arg0, int arg1, int arg2, int arg3);
        Result GetDefaultDisplayResolution(out int arg0, out int arg1);
        Result GetDefaultDisplayResolutionChangeEvent(out int arg0);
        Result GetHdcpAuthenticationState(out int arg0);
        Result GetHdcpAuthenticationStateChangeEvent(out int arg0);
        Result SetTvPowerStateMatchingMode(int arg0);
        Result GetApplicationIdByContentActionName(out ulong arg0, ReadOnlySpan<sbyte> arg1);
        Result SetCpuBoostMode(int arg0);
        Result CancelCpuBoostMode();
        Result GetBuiltInDisplayType(out int arg0);
        Result PerformSystemButtonPressingIfInFocus(SystemButtonType arg0);
        Result SetPerformanceConfigurationChangedNotification(bool arg0);
        Result GetCurrentPerformanceConfiguration(out uint arg0);
        Result SetHandlingHomeButtonShortPressedEnabled(bool arg0);
        Result OpenMyGpuErrorHandler(out IGpuErrorHandler arg0);
        Result GetAppletLaunchedHistory(out int arg0, Span<uint> arg1);
        Result GetOperationModeSystemInfo(out uint arg0);
        Result GetSettingsPlatformRegion(out byte arg0);
        Result ActivateMigrationService();
        Result DeactivateMigrationService();
        Result RestrictPowerOperationForSecureLaunchMode();
        Result SuppressDisablingSleepTemporarily(TimeSpanType arg0);
        Result IsSleepEnabled(out bool arg0);
        Result IsDisablingSleepSuppressed(out bool arg0);
        Result SetRequestExitToLibraryAppletAtExecuteNextProgramEnabled();
    }
}
