using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Bluetooth;
using Ryujinx.Horizon.Sdk.Hid.Server;
using Ryujinx.Horizon.Sdk.Hid.System;
using Ryujinx.Horizon.Sdk.Hidbus;
using Ryujinx.Horizon.Sdk.Hidconfig;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using Ryujinx.Horizon.Sdk.Util;
using Ryujinx.Horizon.Sdk.Xcd;
using System;

namespace Ryujinx.Horizon.Sdk.Hid
{
    class HidSystemServer : IHidSystemServer
    {
        [CmifCommand(31)]
        public Result SendKeyboardLockKeyEvent(KeyboardLockKeyEvent arg0)
        {
            return Result.Success;
        }

        [CmifCommand(101)]
        public Result AcquireHomeButtonEventHandle([CopyHandle] out int arg0, AppletResourceUserId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(111)]
        public Result ActivateHomeButton(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(121)]
        public Result AcquireSleepButtonEventHandle([CopyHandle] out int arg0, AppletResourceUserId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(131)]
        public Result ActivateSleepButton(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(141)]
        public Result AcquireCaptureButtonEventHandle([CopyHandle] out int arg0, AppletResourceUserId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(151)]
        public Result ActivateCaptureButton(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(161)]
        public Result GetPlatformConfig(out PlatformConfig arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(210)]
        public Result AcquireNfcDeviceUpdateEventHandle([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(211)]
        public Result GetNpadsWithNfc(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<uint> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(212)]
        public Result AcquireNfcActivateEventHandle([CopyHandle] out int arg0, uint arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(213)]
        public Result ActivateNfc(uint arg0, bool arg1, AppletResourceUserId arg2)
        {
            return Result.Success;
        }

        [CmifCommand(214)]
        public Result GetXcdHandleForNpadWithNfc(out DeviceHandle arg0, uint arg1, AppletResourceUserId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(215)]
        public Result IsNfcActivated(out bool arg0, uint arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(230)]
        public Result AcquireIrSensorEventHandle([CopyHandle] out int arg0, uint arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(231)]
        public Result ActivateIrSensor(uint arg0, bool arg1, AppletResourceUserId arg2)
        {
            return Result.Success;
        }

        [CmifCommand(232)]
        public Result GetIrSensorState(uint arg0, out long arg1, AppletResourceUserId arg2)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(233)]
        public Result GetXcdHandleForNpadWithIrSensor(uint arg0, out DeviceHandle arg1, AppletResourceUserId arg2)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(301)]
        public Result ActivateNpadSystem(uint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(303)]
        public Result ApplyNpadSystemCommonPolicy(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(304)]
        public Result EnableAssigningSingleOnSlSrPress(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(305)]
        public Result DisableAssigningSingleOnSlSrPress(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(306)]
        public Result GetLastActiveNpad(out uint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(307)]
        public Result GetNpadSystemExtStyle(out long arg0, out long arg1, uint arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(308)]
        public Result ApplyNpadSystemCommonPolicyFull(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(309)]
        public Result GetNpadFullKeyGripColor(out Unorm8x4 arg0, out Unorm8x4 arg1, uint arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(310)]
        public Result GetMaskedSupportedNpadStyleSet(out NpadStyleTag arg0, AppletResourceUserId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(311)]
        public Result SetNpadPlayerLedBlinkingDevice(AppletResourceUserId arg0, uint arg1, DeviceType arg2)
        {
            return Result.Success;
        }

        [CmifCommand(312)]
        public Result SetSupportedNpadStyleSetAll(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(313)]
        public Result GetNpadCaptureButtonAssignment(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<NpadCaptureButtonAssignmentType> arg1, AppletResourceUserId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(314)]
        public Result GetAppletFooterUiType(out AppletFooterUiType arg0, uint arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(315)]
        public Result GetAppletDetailedUiType(out AppletDetailedUiType arg0, uint arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(316)]
        public Result GetNpadInterfaceType(out byte arg0, uint arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(317)]
        public Result GetNpadLeftRightInterfaceType(out byte arg0, out byte arg1, uint arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(318)]
        public Result HasBattery(out bool arg0, uint arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(319)]
        public Result HasLeftRightBattery(out bool arg0, out bool arg1, uint arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(321)]
        public Result GetUniquePadsFromNpad(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<UniquePadId> arg1, uint arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(322)]
        public Result SetNpadSystemExtStateEnabled(AppletResourceUserId arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(323)]
        public Result GetLastActiveUniquePad(out UniquePadId arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(324)]
        public Result GetUniquePadButtonSet(out UniquePadButton arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(325)]
        public Result GetUniquePadColor(out ControllerColor arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(326)]
        public Result GetUniquePadAppletDetailedUiType(out AppletDetailedUiType arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(327)]
        public Result GetAbstractedPadIdDataFromNpad(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<long> arg1, uint arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(328)]
        public Result AttachAbstractedPadToNpad(out bool arg0, long arg1, uint arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(329)]
        public Result DetachAbstractedPadAll()
        {
            return Result.Success;
        }

        [CmifCommand(330)]
        public Result CheckAbstractedPadConnection(long arg0)
        {
            return Result.Success;
        }

        [CmifCommand(500)]
        public Result SetAppletResourceUserId(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(501)]
        public Result RegisterAppletResourceUserId(AppletResourceUserId arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(502)]
        public Result UnregisterAppletResourceUserId(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(503)]
        public Result EnableAppletToGetInput(AppletResourceUserId arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(504)]
        public Result SetAruidValidForVibration(AppletResourceUserId arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(505)]
        public Result EnableAppletToGetSixAxisSensor(AppletResourceUserId arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(506)]
        public Result EnableAppletToGetPadInput(AppletResourceUserId arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(507)]
        public Result EnableAppletToGetTouchScreen(AppletResourceUserId arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(510)]
        public Result SetVibrationMasterVolume(float arg0)
        {
            return Result.Success;
        }

        [CmifCommand(511)]
        public Result GetVibrationMasterVolume(out float arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(512)]
        public Result BeginPermitVibrationSession(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(513)]
        public Result EndPermitVibrationSession()
        {
            return Result.Success;
        }

        [CmifCommand(514)]
        public Result SendVibrationNotificationPattern(AppletResourceUserId arg0, VibrationDeviceHandle arg1, int arg2)
        {
            return Result.Success;
        }

        [CmifCommand(520)]
        public Result EnableHandheldHids()
        {
            return Result.Success;
        }

        [CmifCommand(521)]
        public Result DisableHandheldHids()
        {
            return Result.Success;
        }

        [CmifCommand(522)]
        public Result SetJoyConRailEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(523)]
        public Result IsJoyConRailEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(524)]
        public Result IsHandheldHidsEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(525)]
        public Result IsJoyConAttachedOnAllRail(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(540)]
        public Result AcquirePlayReportControllerUsageUpdateEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(541)]
        public Result GetPlayReportControllerUsages(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<PlayReportControllerUsage> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(542)]
        public Result AcquirePlayReportRegisteredDeviceUpdateEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(543)]
        public Result GetRegisteredDevicesOld(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<RegisteredDeviceOld> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(544)]
        public Result AcquireConnectionTriggerTimeoutEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(545)]
        public Result SendConnectionTrigger(Address arg0)
        {
            return Result.Success;
        }

        [CmifCommand(546)]
        public Result AcquireDeviceRegisteredEventForControllerSupport([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(547)]
        public Result GetAllowedBluetoothLinksCount(out long arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(548)]
        public Result GetRegisteredDevices(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<RegisteredDevice> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(549)]
        public Result GetConnectableRegisteredDevices(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<RegisteredDevice> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(700)]
        public Result ActivateUniquePad(AppletResourceUserId arg0, UniquePadId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(702)]
        public Result AcquireUniquePadConnectionEventHandle([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(703)]
        public Result GetUniquePadIds(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<UniquePadId> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(751)]
        public Result AcquireJoyDetachOnBluetoothOffEventHandle([CopyHandle] out int arg0, AppletResourceUserId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(800)]
        public Result ListSixAxisSensorHandles(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<UniqueSixAxisSensorHandle> arg1, UniquePadId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(801)]
        public Result IsSixAxisSensorUserCalibrationSupported(out bool arg0, UniqueSixAxisSensorHandle arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(802)]
        public Result ResetSixAxisSensorCalibrationValues(UniqueSixAxisSensorHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(803)]
        public Result StartSixAxisSensorUserCalibration(UniqueSixAxisSensorHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(804)]
        public Result CancelSixAxisSensorUserCalibration(UniqueSixAxisSensorHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(805)]
        public Result GetUniquePadBluetoothAddress(out Address arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(806)]
        public Result DisconnectUniquePad(UniquePadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(807)]
        public Result GetUniquePadType(out long arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(808)]
        public Result GetUniquePadInterface(out long arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(809)]
        public Result GetUniquePadSerialNumber(out UniquePadSerialNumber arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(810)]
        public Result GetUniquePadControllerNumber(out long arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(811)]
        public Result GetSixAxisSensorUserCalibrationStage(out long arg0, UniqueSixAxisSensorHandle arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(812)]
        public Result GetConsoleUniqueSixAxisSensorHandle(out UniqueSixAxisSensorHandle arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(821)]
        public Result StartAnalogStickManualCalibration(UniquePadId arg0, long arg1)
        {
            return Result.Success;
        }

        [CmifCommand(822)]
        public Result RetryCurrentAnalogStickManualCalibrationStage(UniquePadId arg0, long arg1)
        {
            return Result.Success;
        }

        [CmifCommand(823)]
        public Result CancelAnalogStickManualCalibration(UniquePadId arg0, long arg1)
        {
            return Result.Success;
        }

        [CmifCommand(824)]
        public Result ResetAnalogStickManualCalibration(UniquePadId arg0, long arg1)
        {
            return Result.Success;
        }

        [CmifCommand(825)]
        public Result GetAnalogStickState(out AnalogStickState arg0, UniquePadId arg1, long arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(826)]
        public Result GetAnalogStickManualCalibrationStage(out long arg0, UniquePadId arg1, long arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(827)]
        public Result IsAnalogStickButtonPressed(out bool arg0, UniquePadId arg1, long arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(828)]
        public Result IsAnalogStickInReleasePosition(out bool arg0, UniquePadId arg1, long arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(829)]
        public Result IsAnalogStickInCircumference(out bool arg0, UniquePadId arg1, long arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(830)]
        public Result SetNotificationLedPattern(NotificationLedPattern arg0, UniquePadId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(831)]
        public Result SetNotificationLedPatternWithTimeout(NotificationLedPattern arg0, UniquePadId arg1, long arg2)
        {
            return Result.Success;
        }

        [CmifCommand(832)]
        public Result PrepareHidsForNotificationWake([Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<UniquePadId> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(850)]
        public Result IsUsbFullKeyControllerEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(851)]
        public Result EnableUsbFullKeyController(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(852)]
        public Result IsUsbConnected(out bool arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(870)]
        public Result IsHandheldButtonPressedOnConsoleMode(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1000)]
        public Result InitializeFirmwareUpdate()
        {
            return Result.Success;
        }

        [CmifCommand(1001)]
        public Result GetFirmwareVersion(out FirmwareVersion arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1002)]
        public Result GetAvailableFirmwareVersion(out FirmwareVersion arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1003)]
        public Result IsFirmwareUpdateAvailable(out bool arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1004)]
        public Result CheckFirmwareUpdateRequired(out long arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1005)]
        public Result StartFirmwareUpdate(out FirmwareUpdateDeviceHandle arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1006)]
        public Result AbortFirmwareUpdate()
        {
            return Result.Success;
        }

        [CmifCommand(1007)]
        public Result GetFirmwareUpdateState(out FirmwareUpdateState arg0, FirmwareUpdateDeviceHandle arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1008)]
        public Result ActivateAudioControl()
        {
            return Result.Success;
        }

        [CmifCommand(1009)]
        public Result AcquireAudioControlEventHandle([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1010)]
        public Result GetAudioControlStates(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<AudioControlState> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1011)]
        public Result DeactivateAudioControl()
        {
            return Result.Success;
        }

        [CmifCommand(1050)]
        public Result IsSixAxisSensorAccurateUserCalibrationSupported(out bool arg0, UniqueSixAxisSensorHandle arg1, AppletResourceUserId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1051)]
        public Result StartSixAxisSensorAccurateUserCalibration(UniqueSixAxisSensorHandle arg0, AppletResourceUserId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1052)]
        public Result CancelSixAxisSensorAccurateUserCalibration(UniqueSixAxisSensorHandle arg0, AppletResourceUserId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1053)]
        public Result GetSixAxisSensorAccurateUserCalibrationState(out SixAxisSensorAccurateUserCalibrationState arg0, UniqueSixAxisSensorHandle arg1, AppletResourceUserId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1100)]
        public Result GetHidbusSystemServiceObject(out IHidbusSystemServer arg0)
        {
            arg0 = new HidbusSystemServer();

            return Result.Success;
        }

        [CmifCommand(1120)]
        public Result SetFirmwareHotfixUpdateSkipEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1130)]
        public Result InitializeUsbFirmwareUpdate(AppletResourceUserId arg0, [CopyHandle] int arg1, ulong arg2)
        {
            return Result.Success;
        }

        [CmifCommand(1131)]
        public Result FinalizeUsbFirmwareUpdate(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1132)]
        public Result CheckUsbFirmwareUpdateRequired(AppletResourceUserId arg0, out long arg1)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(1133)]
        public Result StartUsbFirmwareUpdate(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1134)]
        public Result GetUsbFirmwareUpdateState(AppletResourceUserId arg0, out FirmwareUpdateState arg1, out int arg2, out int arg3)
        {
            arg1 = default;
            arg2 = default;
            arg3 = default;

            return Result.Success;
        }

        [CmifCommand(1150)]
        public Result SetTouchScreenMagnification(float arg0, float arg1, float arg2, float arg3)
        {
            return Result.Success;
        }

        [CmifCommand(1151)]
        public Result GetTouchScreenFirmwareVersion(out FirmwareVersion arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1152)]
        public Result SetTouchScreenDefaultConfiguration(TouchScreenConfigurationForNx arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1153)]
        public Result GetTouchScreenDefaultConfiguration(out TouchScreenConfigurationForNx arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1154)]
        public Result IsFirmwareAvailableForNotification(out bool arg0, int arg1, UniquePadId arg2, AppletResourceUserId arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1155)]
        public Result SetForceHandheldStyleVibration(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1156)]
        public Result SendConnectionTriggerWithoutTimeoutEvent(Address arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1157)]
        public Result CancelConnectionTrigger(Address arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1200)]
        public Result IsButtonConfigSupported(out bool arg0, Address arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1201)]
        public Result IsButtonConfigEmbeddedSupported(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1202)]
        public Result DeleteButtonConfig(Address arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1203)]
        public Result DeleteButtonConfigEmbedded()
        {
            return Result.Success;
        }

        [CmifCommand(1204)]
        public Result SetButtonConfigEnabled(bool arg0, Address arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1205)]
        public Result SetButtonConfigEmbeddedEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1206)]
        public Result IsButtonConfigEnabled(out bool arg0, Address arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1207)]
        public Result IsButtonConfigEmbeddedEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1208)]
        public Result SetButtonConfigEmbedded([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x2C8)] ButtonConfigEmbedded arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1209)]
        public Result SetButtonConfigFull([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x2C8)] ButtonConfigFull arg0, Address arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1211)]
        public Result SetButtonConfigRight([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x1A0)] ButtonConfigRight arg0, Address arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1212)]
        public Result GetButtonConfigEmbedded([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x2C8)] out ButtonConfigEmbedded arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1213)]
        public Result GetButtonConfigFull([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x2C8)] out ButtonConfigFull arg0, Address arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1214)]
        public Result GetButtonConfigLeft([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x1C8)] out ButtonConfigLeft arg0, Address arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1215)]
        public Result GetButtonConfigRight([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x1A0)] out ButtonConfigRight arg0, Address arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1250)]
        public Result IsCustomButtonConfigSupported(out bool arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1251)]
        public Result IsDefaultButtonConfigEmbedded(out bool arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x54)] ButtonConfigEmbedded arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1252)]
        public Result IsDefaultButtonConfigFull(out bool arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x54)] ButtonConfigFull arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1253)]
        public Result IsDefaultButtonConfigLeft(out bool arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x34)] ButtonConfigLeft arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1254)]
        public Result IsDefaultButtonConfigRight(out bool arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x30)] ButtonConfigRight arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1255)]
        public Result IsButtonConfigStorageEmbeddedEmpty(out bool arg0, int arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1256)]
        public Result IsButtonConfigStorageFullEmpty(out bool arg0, int arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1257)]
        public Result IsButtonConfigStorageLeftEmpty(out bool arg0, int arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1258)]
        public Result IsButtonConfigStorageRightEmpty(out bool arg0, int arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1267)]
        public Result DeleteButtonConfigStorageEmbedded(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1268)]
        public Result DeleteButtonConfigStorageFull(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1269)]
        public Result DeleteButtonConfigStorageLeft(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1270)]
        public Result DeleteButtonConfigStorageRight(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1271)]
        public Result IsUsingCustomButtonConfig(out bool arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1272)]
        public Result IsAnyCustomButtonConfigEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1273)]
        public Result SetAllCustomButtonConfigEnabled(bool arg0, AppletResourceUserId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1274)]
        public Result SetDefaultButtonConfig(UniquePadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1275)]
        public Result SetAllDefaultButtonConfig()
        {
            return Result.Success;
        }

        [CmifCommand(1276)]
        public Result SetHidButtonConfigEmbedded([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x54)] ButtonConfigEmbedded arg0, UniquePadId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1277)]
        public Result SetHidButtonConfigFull([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x54)] ButtonConfigFull arg0, UniquePadId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1278)]
        public Result SetHidButtonConfigLeft([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x34)] ButtonConfigLeft arg0, UniquePadId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1279)]
        public Result SetHidButtonConfigRight([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x30)] ButtonConfigRight arg0, UniquePadId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1280)]
        public Result GetHidButtonConfigEmbedded([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x54)] out ButtonConfigEmbedded arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1281)]
        public Result GetHidButtonConfigFull([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x54)] out ButtonConfigFull arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1282)]
        public Result GetHidButtonConfigLeft([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x34)] out ButtonConfigLeft arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1283)]
        public Result GetHidButtonConfigRight([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x30)] out ButtonConfigRight arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1284)]
        public Result GetButtonConfigStorageEmbedded([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x54)] out ButtonConfigEmbedded arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x81)] out StorageName arg1, int arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(1285)]
        public Result GetButtonConfigStorageFull([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x54)] out ButtonConfigFull arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x81)] out StorageName arg1, int arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(1286)]
        public Result GetButtonConfigStorageLeft([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x34)] out ButtonConfigLeft arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x81)] out StorageName arg1, int arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(1287)]
        public Result GetButtonConfigStorageRight([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x30)] out ButtonConfigRight arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x81)] out StorageName arg1, int arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(1288)]
        public Result SetButtonConfigStorageEmbedded([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x54)] ButtonConfigEmbedded arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x81)] StorageName arg1, int arg2)
        {
            return Result.Success;
        }

        [CmifCommand(1289)]
        public Result SetButtonConfigStorageFull([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x54)] ButtonConfigFull arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x81)] StorageName arg1, int arg2)
        {
            return Result.Success;
        }

        [CmifCommand(1290)]
        public Result SetButtonConfigStorageLeft([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x34)] ButtonConfigLeft arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x81)] StorageName arg1, int arg2)
        {
            return Result.Success;
        }

        [CmifCommand(1291)]
        public Result SetButtonConfigStorageRight([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x30)] ButtonConfigRight arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x81)] StorageName arg1, int arg2)
        {
            return Result.Success;
        }

        [CmifCommand(12010)]
        public Result SetButtonConfigLeft([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x1C8)] ButtonConfigLeft arg0, Address arg1)
        {
            return Result.Success;
        }
    }
}
