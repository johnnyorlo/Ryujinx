using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Hid.Debug;
using Ryujinx.Horizon.Sdk.Hid.Debug.Detail;
using Ryujinx.Horizon.Sdk.Hid.Factory;
using Ryujinx.Horizon.Sdk.Hid.System;
using Ryujinx.Horizon.Sdk.Hidtypes;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using Ryujinx.Horizon.Sdk.Util;
using System;

namespace Ryujinx.Horizon.Sdk.Hid
{
    class HidDebugServer : IHidDebugServer
    {
        [CmifCommand(0)]
        public Result DeactivateDebugPad()
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result SetDebugPadAutoPilotState(DebugPadAutoPilotState arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result UnsetDebugPadAutoPilotState()
        {
            return Result.Success;
        }

        [CmifCommand(10)]
        public Result DeactivateTouchScreen()
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result SetTouchScreenAutoPilotState([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<TouchState> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(12)]
        public Result UnsetTouchScreenAutoPilotState()
        {
            return Result.Success;
        }

        [CmifCommand(13)]
        public Result GetTouchScreenConfiguration(out TouchScreenConfigurationForNx arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(14)]
        public Result ProcessTouchScreenAutoTune()
        {
            return Result.Success;
        }

        [CmifCommand(15)]
        public Result ForceStopTouchScreenManagement()
        {
            return Result.Success;
        }

        [CmifCommand(16)]
        public Result ForceRestartTouchScreenManagement(AppletResourceUserId arg0, int arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(17)]
        public Result IsTouchScreenManaged(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20)]
        public Result DeactivateMouse()
        {
            return Result.Success;
        }

        [CmifCommand(21)]
        public Result SetMouseAutoPilotState(MouseAutoPilotState arg0)
        {
            return Result.Success;
        }

        [CmifCommand(22)]
        public Result UnsetMouseAutoPilotState()
        {
            return Result.Success;
        }

        [CmifCommand(30)]
        public Result DeactivateKeyboard()
        {
            return Result.Success;
        }

        [CmifCommand(31)]
        public Result SetKeyboardAutoPilotState(KeyboardAutoPilotState arg0)
        {
            return Result.Success;
        }

        [CmifCommand(32)]
        public Result UnsetKeyboardAutoPilotState()
        {
            return Result.Success;
        }

        [CmifCommand(50)]
        public Result DeactivateXpad(BasicXpadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(60)]
        public Result ClearNpadSystemCommonPolicy(AppletResourceUserId arg0, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(61)]
        public Result DeactivateNpad(AppletResourceUserId arg0, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(62)]
        public Result ForceDisconnectNpad(uint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(91)]
        public Result DeactivateGesture()
        {
            return Result.Success;
        }

        [CmifCommand(110)]
        public Result DeactivateHomeButton()
        {
            return Result.Success;
        }

        [CmifCommand(111)]
        public Result SetHomeButtonAutoPilotState(HomeButtonAutoPilotState arg0)
        {
            return Result.Success;
        }

        [CmifCommand(112)]
        public Result UnsetHomeButtonAutoPilotState()
        {
            return Result.Success;
        }

        [CmifCommand(120)]
        public Result DeactivateSleepButton()
        {
            return Result.Success;
        }

        [CmifCommand(121)]
        public Result SetSleepButtonAutoPilotState(SleepButtonAutoPilotState arg0)
        {
            return Result.Success;
        }

        [CmifCommand(122)]
        public Result UnsetSleepButtonAutoPilotState()
        {
            return Result.Success;
        }

        [CmifCommand(130)]
        public Result DeactivateCaptureButton()
        {
            return Result.Success;
        }

        [CmifCommand(131)]
        public Result SetCaptureButtonAutoPilotState(CaptureButtonAutoPilotState arg0)
        {
            return Result.Success;
        }

        [CmifCommand(132)]
        public Result UnsetCaptureButtonAutoPilotState()
        {
            return Result.Success;
        }

        [CmifCommand(133)]
        public Result SetShiftAccelerometerCalibrationValue(SixAxisSensorHandle arg0, AppletResourceUserId arg1, float arg2, float arg3, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(134)]
        public Result GetShiftAccelerometerCalibrationValue(out float arg0, out float arg1, SixAxisSensorHandle arg2, AppletResourceUserId arg3, [ClientProcessId] ulong pid)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(135)]
        public Result SetShiftGyroscopeCalibrationValue(SixAxisSensorHandle arg0, AppletResourceUserId arg1, float arg2, float arg3, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(136)]
        public Result GetShiftGyroscopeCalibrationValue(out float arg0, out float arg1, SixAxisSensorHandle arg2, AppletResourceUserId arg3, [ClientProcessId] ulong pid)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(140)]
        public Result DeactivateConsoleSixAxisSensor()
        {
            return Result.Success;
        }

        [CmifCommand(141)]
        public Result GetConsoleSixAxisSensorSamplingFrequency(out long arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(142)]
        public Result DeactivateSevenSixAxisSensor()
        {
            return Result.Success;
        }

        [CmifCommand(143)]
        public Result GetConsoleSixAxisSensorCountStates(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.AutoSelect)] Span<ConsoleSixAxisSensorCountState> arg1, AppletResourceUserId arg2, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(144)]
        public Result GetAccelerometerFsr(out AccelerometerFsr arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(145)]
        public Result SetAccelerometerFsr(AccelerometerFsr arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(146)]
        public Result GetAccelerometerOdr(out AccelerometerOdr arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(147)]
        public Result SetAccelerometerOdr(AccelerometerOdr arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(148)]
        public Result GetGyroscopeFsr(out GyroscopeFsr arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(149)]
        public Result SetGyroscopeFsr(GyroscopeFsr arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(150)]
        public Result GetGyroscopeOdr(out GyroscopeOdr arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(151)]
        public Result SetGyroscopeOdr(GyroscopeOdr arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(152)]
        public Result GetWhoAmI(out WhoAmIValue arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(201)]
        public Result ActivateFirmwareUpdate()
        {
            return Result.Success;
        }

        [CmifCommand(202)]
        public Result DeactivateFirmwareUpdate()
        {
            return Result.Success;
        }

        [CmifCommand(203)]
        public Result StartFirmwareUpdate(UniquePadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(204)]
        public Result GetFirmwareUpdateStage(out long arg0, out long arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(205)]
        public Result GetFirmwareVersion(out FirmwareVersion arg0, uint arg1, DeviceType arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(206)]
        public Result GetDestinationFirmwareVersion(out FirmwareVersion arg0, uint arg1, DeviceType arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(207)]
        public Result DiscardFirmwareInfoCacheForRevert()
        {
            return Result.Success;
        }

        [CmifCommand(208)]
        public Result StartFirmwareUpdateForRevert(UniquePadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(209)]
        public Result GetAvailableFirmwareVersionForRevert(out FirmwareVersion arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(210)]
        public Result IsFirmwareUpdatingDevice(out bool arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(211)]
        public Result StartFirmwareUpdateIndividual(out FirmwareUpdateDeviceHandle arg0, UniquePadId arg1, long arg2, [CopyHandle] int arg3, ulong arg4)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(215)]
        public Result SetUsbFirmwareForceUpdateEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(216)]
        public Result SetAllKuinaDevicesToFirmwareUpdateMode()
        {
            return Result.Success;
        }

        [CmifCommand(221)]
        public Result UpdateControllerColor(Unorm8x4 arg0, Unorm8x4 arg1, UniquePadId arg2)
        {
            return Result.Success;
        }

        [CmifCommand(222)]
        public Result ConnectUsbPadsAsync()
        {
            return Result.Success;
        }

        [CmifCommand(223)]
        public Result DisconnectUsbPadsAsync()
        {
            return Result.Success;
        }

        [CmifCommand(224)]
        public Result UpdateDesignInfo(Unorm8x4 arg0, Unorm8x4 arg1, Unorm8x4 arg2, Unorm8x4 arg3, uint arg4, UniquePadId arg5)
        {
            return Result.Success;
        }

        [CmifCommand(225)]
        public Result GetUniquePadDriverState(out PadRawState arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(226)]
        public Result GetSixAxisSensorDriverStates(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<SixAxisSensorState> arg1, UniquePadId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(227)]
        public Result GetRxPacketHistory(out JoyConFormatPacketRxHistory arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(228)]
        public Result AcquireOperationEventHandle([CopyHandle] out int arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(229)]
        public Result ReadSerialFlash(uint arg0, [CopyHandle] int arg1, ulong arg2, UniquePadId arg3)
        {
            return Result.Success;
        }

        [CmifCommand(230)]
        public Result WriteSerialFlash(uint arg0, [CopyHandle] int arg1, ulong arg2, ulong arg3, UniquePadId arg4)
        {
            return Result.Success;
        }

        [CmifCommand(231)]
        public Result GetOperationResult(UniquePadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(232)]
        public Result EnableShipmentMode(UniquePadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(233)]
        public Result ClearPairingInfo(UniquePadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(234)]
        public Result GetUniquePadDeviceTypeSetInternal(out DeviceType arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(235)]
        public Result EnableAnalogStickPower(bool arg0, UniquePadId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(236)]
        public Result RequestKuinaUartClockCal(UniquePadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(237)]
        public Result GetKuinaUartClockCal(out byte arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(238)]
        public Result SetKuinaUartClockTrim(UniquePadId arg0, byte arg1)
        {
            return Result.Success;
        }

        [CmifCommand(239)]
        public Result KuinaLoopbackTest(UniquePadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(240)]
        public Result RequestBatteryVoltage(UniquePadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(241)]
        public Result GetBatteryVoltage(out ushort arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(242)]
        public Result GetUniquePadPowerInfo(out PowerInfo arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(243)]
        public Result RebootUniquePad(UniquePadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(244)]
        public Result RequestKuinaFirmwareVersion(UniquePadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(245)]
        public Result GetKuinaFirmwareVersion(out UsbFirmwareVersion arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(246)]
        public Result GetVidPid(out ushort arg0, out ushort arg1, UniquePadId arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(247)]
        public Result GetAnalogStickCalibrationValue(out AnalogStickCalibrationValue arg0, UniquePadId arg1, AnalogStickDeviceType arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(248)]
        public Result GetUniquePadIdsFull(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<UniquePadId> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(249)]
        public Result ConnectUniquePad(UniquePadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(250)]
        public Result IsVirtual(out bool arg0, out bool arg1, UniquePadId arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(251)]
        public Result GetAnalogStickModuleParam(out AnalogStickModuleParam arg0, UniquePadId arg1, AnalogStickDeviceType arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(323)]
        public Result UnsetAllAutoPilotVirtualPadState()
        {
            return Result.Success;
        }

        [CmifCommand(324)]
        public Result AttachHdlsWorkBuffer(out HdlsSessionId arg0, [CopyHandle] int arg1, ulong arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(325)]
        public Result ReleaseHdlsWorkBuffer(HdlsSessionId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(326)]
        public Result DumpHdlsNpadAssignmentState(HdlsSessionId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(327)]
        public Result DumpHdlsStates(HdlsSessionId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(328)]
        public Result ApplyHdlsNpadAssignmentState(HdlsSessionId arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(329)]
        public Result ApplyHdlsStateList(HdlsSessionId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(330)]
        public Result AttachHdlsVirtualDevice(out HdlsHandle arg0, HdlsDeviceInfo arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(331)]
        public Result DetachHdlsVirtualDevice(HdlsHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(332)]
        public Result SetHdlsState(HdlsHandle arg0, HdlsState arg1)
        {
            return Result.Success;
        }

        [CmifCommand(350)]
        public Result AddRegisteredDevice(RegisteredDevice arg0)
        {
            return Result.Success;
        }

        [CmifCommand(400)]
        public Result DisableExternalMcuOnNxDevice(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(401)]
        public Result DisableRailDeviceFiltering(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(402)]
        public Result EnableWiredPairing(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(403)]
        public Result EnableShipmentModeAutoClear(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(404)]
        public Result SetRailEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(500)]
        public Result SetFactoryInt(bool arg0, UniquePadId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(501)]
        public Result IsFactoryBootEnabled(out bool arg0, UniquePadId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(550)]
        public Result SetAnalogStickModelDataTemporarily(AnalogStickModelData arg0, UniquePadId arg1, int arg2)
        {
            return Result.Success;
        }

        [CmifCommand(551)]
        public Result GetAnalogStickModelData(out AnalogStickModelData arg0, out bool arg1, UniquePadId arg2, int arg3)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(552)]
        public Result ResetAnalogStickModelData(UniquePadId arg0, int arg1)
        {
            return Result.Success;
        }

        [CmifCommand(600)]
        public Result ConvertPadState(out PadState arg0, PadState arg1, UniquePadId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(650)]
        public Result AddButtonPlayData(ButtonPlayData arg0, UniquePadId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(651)]
        public Result StartButtonPlayData(UniquePadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(652)]
        public Result StopButtonPlayData(UniquePadId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2000)]
        public Result DeactivateDigitizer()
        {
            return Result.Success;
        }

        [CmifCommand(2001)]
        public Result SetDigitizerAutoPilotState(DigitizerAutoPilotState arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2002)]
        public Result UnsetDigitizerAutoPilotState()
        {
            return Result.Success;
        }
    }
}
