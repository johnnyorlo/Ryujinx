using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Settings.Factory;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Settings
{
    class FactorySettingsServer : IFactorySettingsServer
    {
        [CmifCommand(0)]
        public Result GetBluetoothBdAddress(out BdAddress arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetConfigurationId1(out ConfigurationId1 arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetAccelerometerOffset(out AccelerometerOffset arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetAccelerometerScale(out AccelerometerScale arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result GetGyroscopeOffset(out GyroscopeOffset arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(5)]
        public Result GetGyroscopeScale(out GyroscopeScale arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(6)]
        public Result GetWirelessLanMacAddress(out MacAddress arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(7)]
        public Result GetWirelessLanCountryCodeCount(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8)]
        public Result GetWirelessLanCountryCodes(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<CountryCode> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(9)]
        public Result GetSerialNumber(out SerialNumber arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result SetInitialSystemAppletProgramId(ProgramId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result SetOverlayDispProgramId(ProgramId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(12)]
        public Result GetBatteryLot(out BatteryLot arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(14)]
        public Result GetEciDeviceCertificate([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x180)] out EccB233DeviceCertificate arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(15)]
        public Result GetEticketDeviceCertificate([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x240)] out Rsa2048DeviceCertificate arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(16)]
        public Result GetSslKey([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x138)] out SslKey arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(17)]
        public Result GetSslCertificate([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x804)] out SslCertificate arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(18)]
        public Result GetGameCardKey([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x138)] out GameCardKey arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(19)]
        public Result GetGameCardCertificate([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x400)] out GameCardCertificate arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20)]
        public Result GetEciDeviceKey(out EccB233DeviceKey arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(21)]
        public Result GetEticketDeviceKey([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x248)] out Rsa2048DeviceKey arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(22)]
        public Result GetSpeakerParameter(out SpeakerParameter arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(23)]
        public Result GetLcdVendorId(out uint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(24)]
        public Result GetEciDeviceCertificate2([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x240)] out Rsa2048DeviceCertificate arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(25)]
        public Result GetEciDeviceKey2([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x248)] out Rsa2048DeviceKey arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(26)]
        public Result GetAmiiboKey(out AmiiboKey arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(27)]
        public Result GetAmiiboEcqvCertificate(out AmiiboEcqvCertificate arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(28)]
        public Result GetAmiiboEcdsaCertificate(out AmiiboEcdsaCertificate arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(29)]
        public Result GetAmiiboEcqvBlsKey(out AmiiboEcqvBlsKey arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(30)]
        public Result GetAmiiboEcqvBlsCertificate(out AmiiboEcqvBlsCertificate arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(31)]
        public Result GetAmiiboEcqvBlsRootCertificate(out AmiiboEcqvBlsRootCertificate arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(32)]
        public Result GetUsbTypeCPowerSourceCircuitVersion(out byte arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(33)]
        public Result GetAnalogStickModuleTypeL(out byte arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(34)]
        public Result GetAnalogStickModelParameterL(out AnalogStickModelParameter arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(35)]
        public Result GetAnalogStickFactoryCalibrationL(out AnalogStickFactoryCalibration arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(36)]
        public Result GetAnalogStickModuleTypeR(out byte arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(37)]
        public Result GetAnalogStickModelParameterR(out AnalogStickModelParameter arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(38)]
        public Result GetAnalogStickFactoryCalibrationR(out AnalogStickFactoryCalibration arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(39)]
        public Result GetConsoleSixAxisSensorModuleType(out byte arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(40)]
        public Result GetConsoleSixAxisSensorHorizontalOffset(out ConsoleSixAxisSensorHorizontalOffset arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(41)]
        public Result GetBatteryVersion(out byte arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(42)]
        public Result GetDeviceId(out ulong arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(43)]
        public Result GetConsoleSixAxisSensorMountType(out byte arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
