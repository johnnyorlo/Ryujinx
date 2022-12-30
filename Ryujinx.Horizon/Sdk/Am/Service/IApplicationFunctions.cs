using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Oe;
using Ryujinx.Horizon.Sdk.Pdm;
using Ryujinx.Horizon.Sdk.Settings;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Time;
using Ryujinx.Horizon.Sdk.Util;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IApplicationFunctions : IServiceObject
    {
        Result PopLaunchParameter(out IStorage arg0, uint arg1);
        Result CreateApplicationAndPushAndRequestToStart(ApplicationId arg0, IStorage arg1);
        Result CreateApplicationAndPushAndRequestToStartForQuest(ApplicationId arg0, IStorage arg1, uint arg2, uint arg3);
        Result CreateApplicationAndRequestToStart(ApplicationId arg0);
        Result CreateApplicationAndRequestToStartForQuest(ApplicationId arg0, uint arg1, uint arg2);
        Result CreateApplicationWithAttributeAndPushAndRequestToStartForQuest(ApplicationId arg0, IStorage arg1, ApplicationAttribute arg2);
        Result CreateApplicationWithAttributeAndRequestToStartForQuest(ApplicationId arg0, ApplicationAttribute arg1);
        Result EnsureSaveData(out long arg0, Uid arg1);
        Result GetDesiredLanguage(out LanguageCode arg0);
        Result SetTerminateResult(uint arg0);
        Result GetDisplayVersion(out DisplayVersion arg0);
        Result GetLaunchStorageInfoForDebug(out StorageId arg0, out StorageId arg1);
        Result ExtendSaveData(out long arg0, byte arg1, Uid arg2, long arg3, long arg4);
        Result GetSaveDataSize(out long arg0, out long arg1, byte arg2, Uid arg3);
        Result CreateCacheStorage(out long arg0, out int arg1, ushort arg2, long arg3, long arg4);
        Result GetSaveDataSizeMax(out long arg0, out long arg1);
        Result GetCacheStorageMax(out int arg0, out long arg1);
        Result BeginBlockingHomeButtonShortAndLongPressed(long arg0);
        Result EndBlockingHomeButtonShortAndLongPressed();
        Result BeginBlockingHomeButton(long arg0);
        Result EndBlockingHomeButton();
        Result SelectApplicationLicense(out ApplicationLicenseType arg0, ReadOnlySpan<ApplicationLicenseType> arg1);
        Result GetDeviceSaveDataSizeMax(out long arg0, out long arg1);
        Result GetLimitedApplicationLicense(out LimitedApplicationLicenseType arg0);
        Result GetLimitedApplicationLicenseUpgradableEvent(out int arg0);
        Result NotifyRunning(out bool arg0);
        Result GetPseudoDeviceId(out Uuid arg0);
        Result SetMediaPlaybackStateForApplication(bool arg0);
        Result IsGamePlayRecordingSupported(out bool arg0);
        Result InitializeGamePlayRecording(int arg0, ulong arg1);
        Result SetGamePlayRecordingState(int arg0);
        Result RequestFlushGamePlayingMovieForDebug();
        Result RequestToShutdown();
        Result RequestToReboot();
        Result RequestToSleep();
        Result ExitAndGoBackQuestMenu();
        Result EnableApplicationCrashReport(bool arg0);
        Result InitializeApplicationCopyrightFrameBuffer(int arg0, ulong arg1, int arg2, int arg3);
        Result SetApplicationCopyrightImage(ReadOnlySpan<byte> arg0, int arg1, int arg2, int arg3, int arg4, int arg5);
        Result SetApplicationCopyrightVisibility(bool arg0);
        Result QueryApplicationPlayStatistics(out int arg0, Span<ApplicationPlayStatistics> arg1, ReadOnlySpan<ApplicationId> arg2);
        Result QueryApplicationPlayStatisticsByUid(out int arg0, Span<ApplicationPlayStatistics> arg1, Uid arg2, ReadOnlySpan<ApplicationId> arg3);
        Result ExecuteProgram(ProgramSpecifyKind arg0, ulong arg1);
        Result ClearUserChannel();
        Result UnpopToUserChannel(IStorage arg0);
        Result GetPreviousProgramIndex(out int arg0);
        Result EnableApplicationAllThreadDumpOnCrash(bool arg0);
        Result GetGpuErrorDetectedSystemEvent(out int arg0);
        Result SetDelayTimeToAbortOnGpuError(long arg0);
        Result GetFriendInvitationStorageChannelEvent(out int arg0);
        Result TryPopFromFriendInvitationStorageChannel(out IStorage arg0);
        Result GetNotificationStorageChannelEvent(out int arg0);
        Result TryPopFromNotificationStorageChannel(out IStorage arg0);
        Result GetHealthWarningDisappearedSystemEvent(out int arg0);
        Result SetHdcpAuthenticationActivated(bool arg0);
        Result GetLaunchRequiredVersion(out LaunchRequiredVersion arg0, ApplicationId arg1, ulong arg2);
        Result UpgradeLaunchRequiredVersion(ApplicationId arg0, LaunchRequiredVersion arg1, ulong arg2);
        Result SendServerMaintenanceOverlayNotification(PosixTime arg0, PosixTime arg1);
        Result GetLastApplicationExitReason(out int arg0);
        Result StartContinuousRecordingFlushForDebug(out int arg0, long arg1);
        Result CreateMovieMaker(out IMovieMaker arg0, int arg1, ulong arg2);
        Result PrepareForJit();
    }
}
