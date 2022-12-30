using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Oe;
using Ryujinx.Horizon.Sdk.Pdm;
using Ryujinx.Horizon.Sdk.Settings;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using Ryujinx.Horizon.Sdk.Time;
using Ryujinx.Horizon.Sdk.Util;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class ApplicationFunctions : IApplicationFunctions
    {
        [CmifCommand(1)]
        public Result PopLaunchParameter(out IStorage arg0, uint arg1)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result CreateApplicationAndPushAndRequestToStart(ApplicationId arg0, IStorage arg1)
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result CreateApplicationAndPushAndRequestToStartForQuest(ApplicationId arg0, IStorage arg1, uint arg2, uint arg3)
        {
            return Result.Success;
        }

        [CmifCommand(12)]
        public Result CreateApplicationAndRequestToStart(ApplicationId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(13)]
        public Result CreateApplicationAndRequestToStartForQuest(ApplicationId arg0, uint arg1, uint arg2)
        {
            return Result.Success;
        }

        [CmifCommand(14)]
        public Result CreateApplicationWithAttributeAndPushAndRequestToStartForQuest(ApplicationId arg0, IStorage arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x20)] in ApplicationAttribute arg2)
        {
            return Result.Success;
        }

        [CmifCommand(15)]
        public Result CreateApplicationWithAttributeAndRequestToStartForQuest(ApplicationId arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x20)] in ApplicationAttribute arg1)
        {
            return Result.Success;
        }

        [CmifCommand(20)]
        public Result EnsureSaveData(out long arg0, Uid arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(21)]
        public Result GetDesiredLanguage(out LanguageCode arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(22)]
        public Result SetTerminateResult(uint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(23)]
        public Result GetDisplayVersion(out DisplayVersion arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(24)]
        public Result GetLaunchStorageInfoForDebug(out StorageId arg0, out StorageId arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(25)]
        public Result ExtendSaveData(out long arg0, byte arg1, Uid arg2, long arg3, long arg4)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(26)]
        public Result GetSaveDataSize(out long arg0, out long arg1, byte arg2, Uid arg3)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(27)]
        public Result CreateCacheStorage(out long arg0, out int arg1, ushort arg2, long arg3, long arg4)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(28)]
        public Result GetSaveDataSizeMax(out long arg0, out long arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(29)]
        public Result GetCacheStorageMax(out int arg0, out long arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(30)]
        public Result BeginBlockingHomeButtonShortAndLongPressed(long arg0)
        {
            return Result.Success;
        }

        [CmifCommand(31)]
        public Result EndBlockingHomeButtonShortAndLongPressed()
        {
            return Result.Success;
        }

        [CmifCommand(32)]
        public Result BeginBlockingHomeButton(long arg0)
        {
            return Result.Success;
        }

        [CmifCommand(33)]
        public Result EndBlockingHomeButton()
        {
            return Result.Success;
        }

        [CmifCommand(34)]
        public Result SelectApplicationLicense(out ApplicationLicenseType arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<ApplicationLicenseType> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(35)]
        public Result GetDeviceSaveDataSizeMax(out long arg0, out long arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(36)]
        public Result GetLimitedApplicationLicense(out LimitedApplicationLicenseType arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(37)]
        public Result GetLimitedApplicationLicenseUpgradableEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(40)]
        public Result NotifyRunning(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(50)]
        public Result GetPseudoDeviceId(out Uuid arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(60)]
        public Result SetMediaPlaybackStateForApplication(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(65)]
        public Result IsGamePlayRecordingSupported(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(66)]
        public Result InitializeGamePlayRecording([CopyHandle] int arg0, ulong arg1)
        {
            return Result.Success;
        }

        [CmifCommand(67)]
        public Result SetGamePlayRecordingState(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(68)]
        public Result RequestFlushGamePlayingMovieForDebug()
        {
            return Result.Success;
        }

        [CmifCommand(70)]
        public Result RequestToShutdown()
        {
            return Result.Success;
        }

        [CmifCommand(71)]
        public Result RequestToReboot()
        {
            return Result.Success;
        }

        [CmifCommand(72)]
        public Result RequestToSleep()
        {
            return Result.Success;
        }

        [CmifCommand(80)]
        public Result ExitAndGoBackQuestMenu()
        {
            return Result.Success;
        }

        [CmifCommand(90)]
        public Result EnableApplicationCrashReport(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(100)]
        public Result InitializeApplicationCopyrightFrameBuffer([CopyHandle] int arg0, ulong arg1, int arg2, int arg3)
        {
            return Result.Success;
        }

        [CmifCommand(101)]
        public Result SetApplicationCopyrightImage([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] ReadOnlySpan<byte> arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
        {
            return Result.Success;
        }

        [CmifCommand(102)]
        public Result SetApplicationCopyrightVisibility(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(110)]
        public Result QueryApplicationPlayStatistics(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ApplicationPlayStatistics> arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<ApplicationId> arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(111)]
        public Result QueryApplicationPlayStatisticsByUid(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ApplicationPlayStatistics> arg1, Uid arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<ApplicationId> arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(120)]
        public Result ExecuteProgram(ProgramSpecifyKind arg0, ulong arg1)
        {
            return Result.Success;
        }

        [CmifCommand(121)]
        public Result ClearUserChannel()
        {
            return Result.Success;
        }

        [CmifCommand(122)]
        public Result UnpopToUserChannel(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(123)]
        public Result GetPreviousProgramIndex(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(124)]
        public Result EnableApplicationAllThreadDumpOnCrash(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(130)]
        public Result GetGpuErrorDetectedSystemEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(131)]
        public Result SetDelayTimeToAbortOnGpuError(long arg0)
        {
            return Result.Success;
        }

        [CmifCommand(140)]
        public Result GetFriendInvitationStorageChannelEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(141)]
        public Result TryPopFromFriendInvitationStorageChannel(out IStorage arg0)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(150)]
        public Result GetNotificationStorageChannelEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(151)]
        public Result TryPopFromNotificationStorageChannel(out IStorage arg0)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(160)]
        public Result GetHealthWarningDisappearedSystemEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(170)]
        public Result SetHdcpAuthenticationActivated(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(180)]
        public Result GetLaunchRequiredVersion(out LaunchRequiredVersion arg0, ApplicationId arg1, ulong arg2, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(181)]
        public Result UpgradeLaunchRequiredVersion(ApplicationId arg0, LaunchRequiredVersion arg1, ulong arg2, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(190)]
        public Result SendServerMaintenanceOverlayNotification(PosixTime arg0, PosixTime arg1)
        {
            return Result.Success;
        }

        [CmifCommand(200)]
        public Result GetLastApplicationExitReason(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(500)]
        public Result StartContinuousRecordingFlushForDebug([CopyHandle] out int arg0, long arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1000)]
        public Result CreateMovieMaker(out IMovieMaker arg0, [CopyHandle] int arg1, ulong arg2)
        {
            arg0 = new MovieMaker();

            return Result.Success;
        }

        [CmifCommand(1001)]
        public Result PrepareForJit()
        {
            return Result.Success;
        }
    }
}
