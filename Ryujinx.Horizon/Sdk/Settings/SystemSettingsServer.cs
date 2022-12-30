using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Fssystem;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Settings.System;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using Ryujinx.Horizon.Sdk.Time;
using Ryujinx.Horizon.Sdk.Util;
using System;

namespace Ryujinx.Horizon.Sdk.Settings
{
    class SystemSettingsServer : ISystemSettingsServer
    {
        [CmifCommand(0)]
        public Result SetLanguageCode(LanguageCode arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result SetNetworkSettings([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<NetworkSettings> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetNetworkSettings(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<NetworkSettings> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetFirmwareVersion([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x100)] out FirmwareVersion arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result GetFirmwareVersion2([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x100)] out FirmwareVersion arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(5)]
        public Result GetFirmwareVersionDigest(out FirmwareVersionDigest arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(7)]
        public Result GetLockScreenFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8)]
        public Result SetLockScreenFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(9)]
        public Result GetBacklightSettings(out BacklightSettings arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result SetBacklightSettings(BacklightSettings arg0)
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result SetBluetoothDevicesSettings([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<BluetoothDevicesSettings> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(12)]
        public Result GetBluetoothDevicesSettings(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<BluetoothDevicesSettings> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(13)]
        public Result GetExternalSteadyClockSourceId(out Uuid arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(14)]
        public Result SetExternalSteadyClockSourceId(Uuid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(15)]
        public Result GetUserSystemClockContext(out SystemClockContext arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(16)]
        public Result SetUserSystemClockContext(SystemClockContext arg0)
        {
            return Result.Success;
        }

        [CmifCommand(17)]
        public Result GetAccountSettings(out AccountSettings arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(18)]
        public Result SetAccountSettings(AccountSettings arg0)
        {
            return Result.Success;
        }

        [CmifCommand(19)]
        public Result GetAudioVolume(out AudioVolume arg0, int arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20)]
        public Result SetAudioVolume(AudioVolume arg0, int arg1)
        {
            return Result.Success;
        }

        [CmifCommand(21)]
        public Result GetEulaVersions(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<EulaVersion> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(22)]
        public Result SetEulaVersions([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<EulaVersion> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(23)]
        public Result GetColorSetId(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(24)]
        public Result SetColorSetId(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(25)]
        public Result GetConsoleInformationUploadFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(26)]
        public Result SetConsoleInformationUploadFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(27)]
        public Result GetAutomaticApplicationDownloadFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(28)]
        public Result SetAutomaticApplicationDownloadFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(29)]
        public Result GetNotificationSettings(out NotificationSettings arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(30)]
        public Result SetNotificationSettings(NotificationSettings arg0)
        {
            return Result.Success;
        }

        [CmifCommand(31)]
        public Result GetAccountNotificationSettings(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<AccountNotificationSettings> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(32)]
        public Result SetAccountNotificationSettings([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<AccountNotificationSettings> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(35)]
        public Result GetVibrationMasterVolume(out float arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(36)]
        public Result SetVibrationMasterVolume(float arg0)
        {
            return Result.Success;
        }

        [CmifCommand(37)]
        public Result GetSettingsItemValueSize(out ulong arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] in SettingsName arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] in SettingsItemKey arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(38)]
        public Result GetSettingsItemValue(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] in SettingsName arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] in SettingsItemKey arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(39)]
        public Result GetTvSettings(out TvSettings arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(40)]
        public Result SetTvSettings(TvSettings arg0)
        {
            return Result.Success;
        }

        [CmifCommand(41)]
        public Result GetEdid([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x200)] out Edid arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(42)]
        public Result SetEdid([Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x200)] in Edid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(43)]
        public Result GetAudioOutputMode(out int arg0, int arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(44)]
        public Result SetAudioOutputMode(int arg0, int arg1)
        {
            return Result.Success;
        }

        [CmifCommand(45)]
        public Result GetSpeakerAutoMuteFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(46)]
        public Result SetSpeakerAutoMuteFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(47)]
        public Result GetQuestFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(48)]
        public Result SetQuestFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(49)]
        public Result GetDataDeletionSettings(out DataDeletionSettings arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(50)]
        public Result SetDataDeletionSettings(DataDeletionSettings arg0)
        {
            return Result.Success;
        }

        [CmifCommand(51)]
        public Result GetInitialSystemAppletProgramId(out ProgramId arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(52)]
        public Result GetOverlayDispProgramId(out ProgramId arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(53)]
        public Result GetDeviceTimeZoneLocationName(out LocationName arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(54)]
        public Result SetDeviceTimeZoneLocationName(LocationName arg0)
        {
            return Result.Success;
        }

        [CmifCommand(55)]
        public Result GetWirelessCertificationFileSize(out ulong arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(56)]
        public Result GetWirelessCertificationFile(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(57)]
        public Result SetRegionCode(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(58)]
        public Result GetNetworkSystemClockContext(out SystemClockContext arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(59)]
        public Result SetNetworkSystemClockContext(SystemClockContext arg0)
        {
            return Result.Success;
        }

        [CmifCommand(60)]
        public Result IsUserSystemClockAutomaticCorrectionEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(61)]
        public Result SetUserSystemClockAutomaticCorrectionEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(62)]
        public Result GetDebugModeFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(63)]
        public Result GetPrimaryAlbumStorage(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(64)]
        public Result SetPrimaryAlbumStorage(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(65)]
        public Result GetUsb30EnableFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(66)]
        public Result SetUsb30EnableFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(67)]
        public Result GetBatteryLot(out BatteryLot arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(68)]
        public Result GetSerialNumber(out SerialNumber arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(69)]
        public Result GetNfcEnableFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(70)]
        public Result SetNfcEnableFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(71)]
        public Result GetSleepSettings(out SleepSettings arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(72)]
        public Result SetSleepSettings(SleepSettings arg0)
        {
            return Result.Success;
        }

        [CmifCommand(73)]
        public Result GetWirelessLanEnableFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(74)]
        public Result SetWirelessLanEnableFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(75)]
        public Result GetInitialLaunchSettings(out InitialLaunchSettings arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(76)]
        public Result SetInitialLaunchSettings(InitialLaunchSettings arg0)
        {
            return Result.Success;
        }

        [CmifCommand(77)]
        public Result GetDeviceNickName([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x80)] out DeviceNickName arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(78)]
        public Result SetDeviceNickName([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x80)] in DeviceNickName arg0)
        {
            return Result.Success;
        }

        [CmifCommand(79)]
        public Result GetProductModel(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(80)]
        public Result GetLdnChannel(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(81)]
        public Result SetLdnChannel(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(82)]
        public Result AcquireTelemetryDirtyFlagEventHandle([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(83)]
        public Result GetTelemetryDirtyFlags(out TelemetryDirtyFlag arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(84)]
        public Result GetPtmBatteryLot(out BatteryLot arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(85)]
        public Result SetPtmBatteryLot(BatteryLot arg0)
        {
            return Result.Success;
        }

        [CmifCommand(86)]
        public Result GetPtmFuelGaugeParameter(out PtmFuelGaugeParameter arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(87)]
        public Result SetPtmFuelGaugeParameter(PtmFuelGaugeParameter arg0)
        {
            return Result.Success;
        }

        [CmifCommand(88)]
        public Result GetBluetoothEnableFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(89)]
        public Result SetBluetoothEnableFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(90)]
        public Result GetMiiAuthorId(out Uuid arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(91)]
        public Result SetShutdownRtcValue(long arg0)
        {
            return Result.Success;
        }

        [CmifCommand(92)]
        public Result GetShutdownRtcValue(out long arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(93)]
        public Result AcquireFatalDirtyFlagEventHandle([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(94)]
        public Result GetFatalDirtyFlags(out FatalDirtyFlag arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(95)]
        public Result GetAutoUpdateEnableFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(96)]
        public Result SetAutoUpdateEnableFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(97)]
        public Result GetNxControllerSettings(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<NxControllerLegacySettings> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(98)]
        public Result SetNxControllerSettings([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<NxControllerLegacySettings> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(99)]
        public Result GetBatteryPercentageFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(100)]
        public Result SetBatteryPercentageFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(101)]
        public Result GetExternalRtcResetFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(102)]
        public Result SetExternalRtcResetFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(103)]
        public Result GetUsbFullKeyEnableFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(104)]
        public Result SetUsbFullKeyEnableFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(105)]
        public Result SetExternalSteadyClockInternalOffset(long arg0)
        {
            return Result.Success;
        }

        [CmifCommand(106)]
        public Result GetExternalSteadyClockInternalOffset(out long arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(107)]
        public Result GetBacklightSettingsEx(out BacklightSettingsEx arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(108)]
        public Result SetBacklightSettingsEx(BacklightSettingsEx arg0)
        {
            return Result.Success;
        }

        [CmifCommand(109)]
        public Result GetHeadphoneVolumeWarningCount(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(110)]
        public Result SetHeadphoneVolumeWarningCount(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(111)]
        public Result GetBluetoothAfhEnableFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(112)]
        public Result SetBluetoothAfhEnableFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(113)]
        public Result GetBluetoothBoostEnableFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(114)]
        public Result SetBluetoothBoostEnableFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(115)]
        public Result GetInRepairProcessEnableFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(116)]
        public Result SetInRepairProcessEnableFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(117)]
        public Result GetHeadphoneVolumeUpdateFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(118)]
        public Result SetHeadphoneVolumeUpdateFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(119)]
        public Result NeedsToUpdateHeadphoneVolume(out bool arg0, out bool arg1, out sbyte arg2, bool arg3)
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;

            return Result.Success;
        }

        [CmifCommand(120)]
        public Result GetPushNotificationActivityModeOnSleep(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(121)]
        public Result SetPushNotificationActivityModeOnSleep(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(122)]
        public Result GetServiceDiscoveryControlSettings(out ServiceDiscoveryControlSettings arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(123)]
        public Result SetServiceDiscoveryControlSettings(ServiceDiscoveryControlSettings arg0)
        {
            return Result.Success;
        }

        [CmifCommand(124)]
        public Result GetErrorReportSharePermission(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(125)]
        public Result SetErrorReportSharePermission(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(126)]
        public Result GetAppletLaunchFlags(out AppletLaunchFlag arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(127)]
        public Result SetAppletLaunchFlags(AppletLaunchFlag arg0)
        {
            return Result.Success;
        }

        [CmifCommand(128)]
        public Result GetConsoleSixAxisSensorAccelerationBias(out ConsoleSixAxisSensorAccelerationBias arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(129)]
        public Result SetConsoleSixAxisSensorAccelerationBias(ConsoleSixAxisSensorAccelerationBias arg0)
        {
            return Result.Success;
        }

        [CmifCommand(130)]
        public Result GetConsoleSixAxisSensorAngularVelocityBias(out ConsoleSixAxisSensorAngularVelocityBias arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(131)]
        public Result SetConsoleSixAxisSensorAngularVelocityBias(ConsoleSixAxisSensorAngularVelocityBias arg0)
        {
            return Result.Success;
        }

        [CmifCommand(132)]
        public Result GetConsoleSixAxisSensorAccelerationGain(out ConsoleSixAxisSensorAccelerationGain arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(133)]
        public Result SetConsoleSixAxisSensorAccelerationGain(ConsoleSixAxisSensorAccelerationGain arg0)
        {
            return Result.Success;
        }

        [CmifCommand(134)]
        public Result GetConsoleSixAxisSensorAngularVelocityGain(out ConsoleSixAxisSensorAngularVelocityGain arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(135)]
        public Result SetConsoleSixAxisSensorAngularVelocityGain(ConsoleSixAxisSensorAngularVelocityGain arg0)
        {
            return Result.Success;
        }

        [CmifCommand(136)]
        public Result GetKeyboardLayout(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(137)]
        public Result SetKeyboardLayout(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(138)]
        public Result GetWebInspectorFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(139)]
        public Result GetAllowedSslHosts(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<AllowedSslHost> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(140)]
        public Result GetHostFsMountPoint([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x100)] out HostFsMountPoint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(141)]
        public Result GetRequiresRunRepairTimeReviser(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(142)]
        public Result SetRequiresRunRepairTimeReviser(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(143)]
        public Result SetBlePairingSettings([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<BlePairingSettings> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(144)]
        public Result GetBlePairingSettings(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<BlePairingSettings> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(145)]
        public Result GetConsoleSixAxisSensorAngularVelocityTimeBias(out ConsoleSixAxisSensorAngularVelocityTimeBias arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(146)]
        public Result SetConsoleSixAxisSensorAngularVelocityTimeBias(ConsoleSixAxisSensorAngularVelocityTimeBias arg0)
        {
            return Result.Success;
        }

        [CmifCommand(147)]
        public Result GetConsoleSixAxisSensorAngularAcceleration(out ConsoleSixAxisSensorAngularAcceleration arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(148)]
        public Result SetConsoleSixAxisSensorAngularAcceleration(ConsoleSixAxisSensorAngularAcceleration arg0)
        {
            return Result.Success;
        }

        [CmifCommand(149)]
        public Result GetRebootlessSystemUpdateVersion(out RebootlessSystemUpdateVersion arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(150)]
        public Result GetDeviceTimeZoneLocationUpdatedTime(out SteadyClockTimePoint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(151)]
        public Result SetDeviceTimeZoneLocationUpdatedTime(SteadyClockTimePoint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(152)]
        public Result GetUserSystemClockAutomaticCorrectionUpdatedTime(out SteadyClockTimePoint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(153)]
        public Result SetUserSystemClockAutomaticCorrectionUpdatedTime(SteadyClockTimePoint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(154)]
        public Result GetAccountOnlineStorageSettings(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<AccountOnlineStorageSettings> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(155)]
        public Result SetAccountOnlineStorageSettings([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<AccountOnlineStorageSettings> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(156)]
        public Result GetPctlReadyFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(157)]
        public Result SetPctlReadyFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(158)]
        public Result GetAnalogStickUserCalibrationL(out AnalogStickUserCalibration arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(159)]
        public Result SetAnalogStickUserCalibrationL(AnalogStickUserCalibration arg0)
        {
            return Result.Success;
        }

        [CmifCommand(160)]
        public Result GetAnalogStickUserCalibrationR(out AnalogStickUserCalibration arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(161)]
        public Result SetAnalogStickUserCalibrationR(AnalogStickUserCalibration arg0)
        {
            return Result.Success;
        }

        [CmifCommand(162)]
        public Result GetPtmBatteryVersion(out byte arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(163)]
        public Result SetPtmBatteryVersion(byte arg0)
        {
            return Result.Success;
        }

        [CmifCommand(164)]
        public Result GetUsb30HostEnableFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(165)]
        public Result SetUsb30HostEnableFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(166)]
        public Result GetUsb30DeviceEnableFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(167)]
        public Result SetUsb30DeviceEnableFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(168)]
        public Result GetThemeId(out ThemeId arg0, int arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(169)]
        public Result SetThemeId(ThemeId arg0, int arg1)
        {
            return Result.Success;
        }

        [CmifCommand(170)]
        public Result GetChineseTraditionalInputMethod(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(171)]
        public Result SetChineseTraditionalInputMethod(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(172)]
        public Result GetPtmCycleCountReliability(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(173)]
        public Result SetPtmCycleCountReliability(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(174)]
        public Result GetHomeMenuScheme(out HomeMenuScheme arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(175)]
        public Result GetThemeSettings(out ThemeSettings arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(176)]
        public Result SetThemeSettings(ThemeSettings arg0)
        {
            return Result.Success;
        }

        [CmifCommand(177)]
        public Result GetThemeKey(out ArchiveMacKey arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(178)]
        public Result SetThemeKey(ArchiveMacKey arg0)
        {
            return Result.Success;
        }

        [CmifCommand(179)]
        public Result GetZoomFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(180)]
        public Result SetZoomFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(181)]
        public Result GetT(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(182)]
        public Result SetT(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(183)]
        public Result GetPlatformRegion(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(184)]
        public Result SetPlatformRegion(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(185)]
        public Result GetHomeMenuSchemeModel(out uint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(186)]
        public Result GetMemoryUsageRateFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(187)]
        public Result GetTouchScreenMode(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(188)]
        public Result SetTouchScreenMode(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(189)]
        public Result GetButtonConfigSettingsFull(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ButtonConfigSettings> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(190)]
        public Result SetButtonConfigSettingsFull([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<ButtonConfigSettings> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(191)]
        public Result GetButtonConfigSettingsEmbedded(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ButtonConfigSettings> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(192)]
        public Result SetButtonConfigSettingsEmbedded([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<ButtonConfigSettings> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(193)]
        public Result GetButtonConfigSettingsLeft(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ButtonConfigSettings> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(194)]
        public Result SetButtonConfigSettingsLeft([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<ButtonConfigSettings> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(195)]
        public Result GetButtonConfigSettingsRight(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ButtonConfigSettings> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(196)]
        public Result SetButtonConfigSettingsRight([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<ButtonConfigSettings> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(197)]
        public Result GetButtonConfigRegisteredSettingsEmbedded([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x5C8)] out ButtonConfigRegisteredSettings arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(198)]
        public Result SetButtonConfigRegisteredSettingsEmbedded([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x5C8)] in ButtonConfigRegisteredSettings arg0)
        {
            return Result.Success;
        }

        [CmifCommand(199)]
        public Result GetButtonConfigRegisteredSettings(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ButtonConfigRegisteredSettings> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(200)]
        public Result SetButtonConfigRegisteredSettings([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<ButtonConfigRegisteredSettings> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(201)]
        public Result GetFieldTestingFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(202)]
        public Result SetFieldTestingFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(203)]
        public Result GetPanelCrcMode(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(204)]
        public Result SetPanelCrcMode(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(205)]
        public Result GetNxControllerSettingsEx(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<NxControllerSettings> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(206)]
        public Result SetNxControllerSettingsEx([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<NxControllerSettings> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(207)]
        public Result GetHearingProtectionSafeguardFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(208)]
        public Result SetHearingProtectionSafeguardFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(209)]
        public Result GetHearingProtectionSafeguardRemainingTime(out TimeSpanType arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(210)]
        public Result SetHearingProtectionSafeguardRemainingTime(TimeSpanType arg0)
        {
            return Result.Success;
        }
    }
}
