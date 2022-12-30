using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Bluetooth;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Hid
{
    class HidServer : IHidServer
    {
        [CmifCommand(0)]
        public Result CreateAppletResource(out IAppletResource arg0, AppletResourceUserId arg1)
        {
            arg0 = new AppletResource();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result ActivateDebugPad(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result ActivateTouchScreen(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(21)]
        public Result ActivateMouse(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(31)]
        public Result ActivateKeyboard(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(32)]
        public Result SendKeyboardLockKeyEvent(AppletResourceUserId arg0, KeyboardLockKeyEvent arg1)
        {
            return Result.Success;
        }

        [CmifCommand(40)]
        public Result AcquireXpadIdEventHandle([CopyHandle] out int arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(41)]
        public Result ReleaseXpadIdEventHandle(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(51)]
        public Result ActivateXpad(AppletResourceUserId arg0, BasicXpadId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(55)]
        public Result GetXpadIds(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<BasicXpadId> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(56)]
        public Result ActivateJoyXpad(JoyXpadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(58)]
        public Result GetJoyXpadLifoHandle([CopyHandle] out int arg0, JoyXpadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(59)]
        public Result GetJoyXpadIds(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<JoyXpadId> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(60)]
        public Result ActivateSixAxisSensor(BasicXpadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(61)]
        public Result DeactivateSixAxisSensor(BasicXpadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(62)]
        public Result GetSixAxisSensorLifoHandle([CopyHandle] out int arg0, BasicXpadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(63)]
        public Result ActivateJoySixAxisSensor(JoyXpadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(64)]
        public Result DeactivateJoySixAxisSensor(JoyXpadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(65)]
        public Result GetJoySixAxisSensorLifoHandle([CopyHandle] out int arg0, JoyXpadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(66)]
        public Result StartSixAxisSensor(AppletResourceUserId arg0, SixAxisSensorHandle arg1)
        {
            return Result.Success;
        }

        [CmifCommand(67)]
        public Result StopSixAxisSensor(AppletResourceUserId arg0, SixAxisSensorHandle arg1)
        {
            return Result.Success;
        }

        [CmifCommand(68)]
        public Result IsSixAxisSensorFusionEnabled(out bool arg0, AppletResourceUserId arg1, SixAxisSensorHandle arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(69)]
        public Result EnableSixAxisSensorFusion(AppletResourceUserId arg0, SixAxisSensorHandle arg1, bool arg2)
        {
            return Result.Success;
        }

        [CmifCommand(70)]
        public Result SetSixAxisSensorFusionParameters(AppletResourceUserId arg0, SixAxisSensorHandle arg1, float arg2, float arg3)
        {
            return Result.Success;
        }

        [CmifCommand(71)]
        public Result GetSixAxisSensorFusionParameters(out float arg0, out float arg1, AppletResourceUserId arg2, SixAxisSensorHandle arg3)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(72)]
        public Result ResetSixAxisSensorFusionParameters(AppletResourceUserId arg0, SixAxisSensorHandle arg1)
        {
            return Result.Success;
        }

        [CmifCommand(73)]
        public Result SetAccelerometerParameters(AppletResourceUserId arg0, SixAxisSensorHandle arg1, float arg2, float arg3)
        {
            return Result.Success;
        }

        [CmifCommand(74)]
        public Result GetAccelerometerParameters(out float arg0, out float arg1, AppletResourceUserId arg2, SixAxisSensorHandle arg3)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(75)]
        public Result ResetAccelerometerParameters(AppletResourceUserId arg0, SixAxisSensorHandle arg1)
        {
            return Result.Success;
        }

        [CmifCommand(76)]
        public Result SetAccelerometerPlayMode(AppletResourceUserId arg0, SixAxisSensorHandle arg1, uint arg2)
        {
            return Result.Success;
        }

        [CmifCommand(77)]
        public Result GetAccelerometerPlayMode(out uint arg0, AppletResourceUserId arg1, SixAxisSensorHandle arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(78)]
        public Result ResetAccelerometerPlayMode(AppletResourceUserId arg0, SixAxisSensorHandle arg1)
        {
            return Result.Success;
        }

        [CmifCommand(79)]
        public Result SetGyroscopeZeroDriftMode(AppletResourceUserId arg0, SixAxisSensorHandle arg1, uint arg2)
        {
            return Result.Success;
        }

        [CmifCommand(80)]
        public Result GetGyroscopeZeroDriftMode(out uint arg0, AppletResourceUserId arg1, SixAxisSensorHandle arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(81)]
        public Result ResetGyroscopeZeroDriftMode(AppletResourceUserId arg0, SixAxisSensorHandle arg1)
        {
            return Result.Success;
        }

        [CmifCommand(82)]
        public Result IsSixAxisSensorAtRest(out bool arg0, AppletResourceUserId arg1, SixAxisSensorHandle arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(83)]
        public Result IsFirmwareUpdateAvailableForSixAxisSensor(out bool arg0, AppletResourceUserId arg1, SixAxisSensorHandle arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(84)]
        public Result EnableSixAxisSensorUnalteredPassthrough(AppletResourceUserId arg0, SixAxisSensorHandle arg1, bool arg2)
        {
            return Result.Success;
        }

        [CmifCommand(85)]
        public Result IsSixAxisSensorUnalteredPassthroughEnabled(out bool arg0, AppletResourceUserId arg1, SixAxisSensorHandle arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(86)]
        public Result StoreSixAxisSensorCalibrationParameter(AppletResourceUserId arg0, SixAxisSensorHandle arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x744)] SixAxisSensorCalibrationParameter arg2)
        {
            return Result.Success;
        }

        [CmifCommand(87)]
        public Result LoadSixAxisSensorCalibrationParameter(AppletResourceUserId arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x744)] out SixAxisSensorCalibrationParameter arg1, SixAxisSensorHandle arg2)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(88)]
        public Result GetSixAxisSensorIcInformation(AppletResourceUserId arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0xC8)] out SixAxisSensorIcInformation arg1, SixAxisSensorHandle arg2)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(89)]
        public Result ResetIsSixAxisSensorDeviceNewlyAssigned(AppletResourceUserId arg0, SixAxisSensorHandle arg1)
        {
            return Result.Success;
        }

        [CmifCommand(91)]
        public Result ActivateGesture(AppletResourceUserId arg0, int arg1)
        {
            return Result.Success;
        }

        [CmifCommand(100)]
        public Result SetSupportedNpadStyleSet(AppletResourceUserId arg0, NpadStyleTag arg1)
        {
            return Result.Success;
        }

        [CmifCommand(101)]
        public Result GetSupportedNpadStyleSet(AppletResourceUserId arg0, out NpadStyleTag arg1)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(102)]
        public Result SetSupportedNpadIdType(AppletResourceUserId arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<uint> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(103)]
        public Result ActivateNpad(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(104)]
        public Result DeactivateNpad(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(106)]
        public Result AcquireNpadStyleSetUpdateEventHandle(AppletResourceUserId arg0, [CopyHandle] out int arg1, uint arg2, ulong arg3)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(107)]
        public Result DisconnectNpad(AppletResourceUserId arg0, uint arg1)
        {
            return Result.Success;
        }

        [CmifCommand(108)]
        public Result GetPlayerLedPattern(out ulong arg0, uint arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(109)]
        public Result ActivateNpadWithRevision(AppletResourceUserId arg0, int arg1)
        {
            return Result.Success;
        }

        [CmifCommand(120)]
        public Result SetNpadJoyHoldType(AppletResourceUserId arg0, long arg1)
        {
            return Result.Success;
        }

        [CmifCommand(121)]
        public Result GetNpadJoyHoldType(AppletResourceUserId arg0, out long arg1)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(122)]
        public Result SetNpadJoyAssignmentModeSingleByDefault(AppletResourceUserId arg0, uint arg1)
        {
            return Result.Success;
        }

        [CmifCommand(123)]
        public Result SetNpadJoyAssignmentModeSingle(AppletResourceUserId arg0, uint arg1, long arg2)
        {
            return Result.Success;
        }

        [CmifCommand(124)]
        public Result SetNpadJoyAssignmentModeDual(AppletResourceUserId arg0, uint arg1)
        {
            return Result.Success;
        }

        [CmifCommand(125)]
        public Result MergeSingleJoyAsDualJoy(AppletResourceUserId arg0, uint arg1, uint arg2)
        {
            return Result.Success;
        }

        [CmifCommand(126)]
        public Result StartLrAssignmentMode(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(127)]
        public Result StopLrAssignmentMode(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(128)]
        public Result SetNpadHandheldActivationMode(AppletResourceUserId arg0, long arg1)
        {
            return Result.Success;
        }

        [CmifCommand(129)]
        public Result GetNpadHandheldActivationMode(AppletResourceUserId arg0, out long arg1)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(130)]
        public Result SwapNpadAssignment(AppletResourceUserId arg0, uint arg1, uint arg2)
        {
            return Result.Success;
        }

        [CmifCommand(131)]
        public Result IsUnintendedHomeButtonInputProtectionEnabled(out bool arg0, AppletResourceUserId arg1, uint arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(132)]
        public Result EnableUnintendedHomeButtonInputProtection(AppletResourceUserId arg0, uint arg1, bool arg2)
        {
            return Result.Success;
        }

        [CmifCommand(133)]
        public Result SetNpadJoyAssignmentModeSingleWithDestination(out bool arg0, out uint arg1, AppletResourceUserId arg2, uint arg3, long arg4)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(134)]
        public Result SetNpadAnalogStickUseCenterClamp(AppletResourceUserId arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(135)]
        public Result SetNpadCaptureButtonAssignment(AppletResourceUserId arg0, NpadStyleTag arg1, NpadButton arg2)
        {
            return Result.Success;
        }

        [CmifCommand(136)]
        public Result ClearNpadCaptureButtonAssignment(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(200)]
        public Result GetVibrationDeviceInfo(out VibrationDeviceInfoForIpc arg0, VibrationDeviceHandle arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(201)]
        public Result SendVibrationValue(AppletResourceUserId arg0, VibrationDeviceHandle arg1, VibrationValue arg2)
        {
            return Result.Success;
        }

        [CmifCommand(202)]
        public Result GetActualVibrationValue(out VibrationValue arg0, AppletResourceUserId arg1, VibrationDeviceHandle arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(203)]
        public Result CreateActiveVibrationDeviceList(out IActiveVibrationDeviceList arg0)
        {
            arg0 = new ActiveVibrationDeviceList();

            return Result.Success;
        }

        [CmifCommand(204)]
        public Result PermitVibration(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(205)]
        public Result IsVibrationPermitted(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(206)]
        public Result SendVibrationValues(AppletResourceUserId arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<VibrationDeviceHandle> arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<VibrationValue> arg2)
        {
            return Result.Success;
        }

        [CmifCommand(207)]
        public Result SendVibrationGcErmCommand(AppletResourceUserId arg0, VibrationDeviceHandle arg1, VibrationGcErmCommand arg2)
        {
            return Result.Success;
        }

        [CmifCommand(208)]
        public Result GetActualVibrationGcErmCommand(out VibrationGcErmCommand arg0, AppletResourceUserId arg1, VibrationDeviceHandle arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(209)]
        public Result BeginPermitVibrationSession(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(210)]
        public Result EndPermitVibrationSession()
        {
            return Result.Success;
        }

        [CmifCommand(211)]
        public Result IsVibrationDeviceMounted(out bool arg0, AppletResourceUserId arg1, VibrationDeviceHandle arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(212)]
        public Result SendVibrationValueInBool(AppletResourceUserId arg0, VibrationDeviceHandle arg1, bool arg2)
        {
            return Result.Success;
        }

        [CmifCommand(300)]
        public Result ActivateConsoleSixAxisSensor(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(301)]
        public Result StartConsoleSixAxisSensor(AppletResourceUserId arg0, ConsoleSixAxisSensorHandle arg1)
        {
            return Result.Success;
        }

        [CmifCommand(302)]
        public Result StopConsoleSixAxisSensor(AppletResourceUserId arg0, ConsoleSixAxisSensorHandle arg1)
        {
            return Result.Success;
        }

        [CmifCommand(303)]
        public Result ActivateSevenSixAxisSensor(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(304)]
        public Result StartSevenSixAxisSensor(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(305)]
        public Result StopSevenSixAxisSensor(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(306)]
        public Result InitializeSevenSixAxisSensor(AppletResourceUserId arg0, [CopyHandle] int arg1, ulong arg2, [CopyHandle] int arg3, ulong arg4)
        {
            return Result.Success;
        }

        [CmifCommand(307)]
        public Result FinalizeSevenSixAxisSensor(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(308)]
        public Result SetSevenSixAxisSensorFusionStrength(AppletResourceUserId arg0, float arg1)
        {
            return Result.Success;
        }

        [CmifCommand(309)]
        public Result GetSevenSixAxisSensorFusionStrength(out float arg0, AppletResourceUserId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(310)]
        public Result ResetSevenSixAxisSensorTimestamp(AppletResourceUserId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(400)]
        public Result IsUsbFullKeyControllerEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(401)]
        public Result EnableUsbFullKeyController(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(402)]
        public Result IsUsbFullKeyControllerConnected(out bool arg0, uint arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(403)]
        public Result HasBattery(out bool arg0, uint arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(404)]
        public Result HasLeftRightBattery(out bool arg0, out bool arg1, uint arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(405)]
        public Result GetNpadInterfaceType(out byte arg0, uint arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(406)]
        public Result GetNpadLeftRightInterfaceType(out byte arg0, out byte arg1, uint arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(407)]
        public Result GetNpadOfHighestBatteryLevel(out uint arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<uint> arg1, AppletResourceUserId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(500)]
        public Result GetPalmaConnectionHandle(out PalmaConnectionHandle arg0, uint arg1, AppletResourceUserId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(501)]
        public Result InitializePalma(PalmaConnectionHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(502)]
        public Result AcquirePalmaOperationCompleteEvent([CopyHandle] out int arg0, PalmaConnectionHandle arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(503)]
        public Result GetPalmaOperationInfo(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1, PalmaConnectionHandle arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(504)]
        public Result PlayPalmaActivity(PalmaConnectionHandle arg0, ulong arg1)
        {
            return Result.Success;
        }

        [CmifCommand(505)]
        public Result SetPalmaFrModeType(PalmaConnectionHandle arg0, ulong arg1)
        {
            return Result.Success;
        }

        [CmifCommand(506)]
        public Result ReadPalmaStep(PalmaConnectionHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(507)]
        public Result EnablePalmaStep(PalmaConnectionHandle arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(508)]
        public Result ResetPalmaStep(PalmaConnectionHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(509)]
        public Result ReadPalmaApplicationSection(PalmaConnectionHandle arg0, ulong arg1, ulong arg2)
        {
            return Result.Success;
        }

        [CmifCommand(510)]
        public Result WritePalmaApplicationSection(PalmaConnectionHandle arg0, ulong arg1, ulong arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x100)] PalmaApplicationSectionAccessBuffer arg3)
        {
            return Result.Success;
        }

        [CmifCommand(511)]
        public Result ReadPalmaUniqueCode(PalmaConnectionHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(512)]
        public Result SetPalmaUniqueCodeInvalid(PalmaConnectionHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(513)]
        public Result WritePalmaActivityEntry(PalmaConnectionHandle arg0, ulong arg1, ulong arg2, ulong arg3, ulong arg4)
        {
            return Result.Success;
        }

        [CmifCommand(514)]
        public Result WritePalmaRgbLedPatternEntry(PalmaConnectionHandle arg0, ulong arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2)
        {
            return Result.Success;
        }

        [CmifCommand(515)]
        public Result WritePalmaWaveEntry(PalmaConnectionHandle arg0, ulong arg1, ulong arg2, [CopyHandle] int arg3, ulong arg4, ulong arg5)
        {
            return Result.Success;
        }

        [CmifCommand(516)]
        public Result SetPalmaDataBaseIdentificationVersion(PalmaConnectionHandle arg0, int arg1)
        {
            return Result.Success;
        }

        [CmifCommand(517)]
        public Result GetPalmaDataBaseIdentificationVersion(PalmaConnectionHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(518)]
        public Result SuspendPalmaFeature(PalmaConnectionHandle arg0, PalmaFeature arg1)
        {
            return Result.Success;
        }

        [CmifCommand(519)]
        public Result GetPalmaOperationResult(PalmaConnectionHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(520)]
        public Result ReadPalmaPlayLog(PalmaConnectionHandle arg0, ushort arg1)
        {
            return Result.Success;
        }

        [CmifCommand(521)]
        public Result ResetPalmaPlayLog(PalmaConnectionHandle arg0, ushort arg1)
        {
            return Result.Success;
        }

        [CmifCommand(522)]
        public Result SetIsPalmaAllConnectable(AppletResourceUserId arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(523)]
        public Result SetIsPalmaPairedConnectable(AppletResourceUserId arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(524)]
        public Result PairPalma(PalmaConnectionHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(525)]
        public Result SetPalmaBoostMode(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(526)]
        public Result CancelWritePalmaWaveEntry(PalmaConnectionHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(527)]
        public Result EnablePalmaBoostMode(AppletResourceUserId arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(528)]
        public Result GetPalmaBluetoothAddress(out Address arg0, PalmaConnectionHandle arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(529)]
        public Result SetDisallowedPalmaConnection(AppletResourceUserId arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<Address> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1000)]
        public Result SetNpadCommunicationMode(AppletResourceUserId arg0, long arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1001)]
        public Result GetNpadCommunicationMode(out long arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1002)]
        public Result SetTouchScreenConfiguration(AppletResourceUserId arg0, TouchScreenConfigurationForNx arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1003)]
        public Result IsFirmwareUpdateNeededForNotification(out bool arg0, int arg1, AppletResourceUserId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2000)]
        public Result ActivateDigitizer(AppletResourceUserId arg0)
        {
            return Result.Success;
        }
    }
}
