using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Settings.Factory;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Settings
{
    interface IFactorySettingsServer : IServiceObject
    {
        Result GetBluetoothBdAddress(out BdAddress arg0);
        Result GetConfigurationId1(out ConfigurationId1 arg0);
        Result GetAccelerometerOffset(out AccelerometerOffset arg0);
        Result GetAccelerometerScale(out AccelerometerScale arg0);
        Result GetGyroscopeOffset(out GyroscopeOffset arg0);
        Result GetGyroscopeScale(out GyroscopeScale arg0);
        Result GetWirelessLanMacAddress(out MacAddress arg0);
        Result GetWirelessLanCountryCodeCount(out int arg0);
        Result GetWirelessLanCountryCodes(out int arg0, Span<CountryCode> arg1);
        Result GetSerialNumber(out SerialNumber arg0);
        Result SetInitialSystemAppletProgramId(ProgramId arg0);
        Result SetOverlayDispProgramId(ProgramId arg0);
        Result GetBatteryLot(out BatteryLot arg0);
        Result GetEciDeviceCertificate(out EccB233DeviceCertificate arg0);
        Result GetEticketDeviceCertificate(out Rsa2048DeviceCertificate arg0);
        Result GetSslKey(out SslKey arg0);
        Result GetSslCertificate(out SslCertificate arg0);
        Result GetGameCardKey(out GameCardKey arg0);
        Result GetGameCardCertificate(out GameCardCertificate arg0);
        Result GetEciDeviceKey(out EccB233DeviceKey arg0);
        Result GetEticketDeviceKey(out Rsa2048DeviceKey arg0);
        Result GetSpeakerParameter(out SpeakerParameter arg0);
        Result GetLcdVendorId(out uint arg0);
        Result GetEciDeviceCertificate2(out Rsa2048DeviceCertificate arg0);
        Result GetEciDeviceKey2(out Rsa2048DeviceKey arg0);
        Result GetAmiiboKey(out AmiiboKey arg0);
        Result GetAmiiboEcqvCertificate(out AmiiboEcqvCertificate arg0);
        Result GetAmiiboEcdsaCertificate(out AmiiboEcdsaCertificate arg0);
        Result GetAmiiboEcqvBlsKey(out AmiiboEcqvBlsKey arg0);
        Result GetAmiiboEcqvBlsCertificate(out AmiiboEcqvBlsCertificate arg0);
        Result GetAmiiboEcqvBlsRootCertificate(out AmiiboEcqvBlsRootCertificate arg0);
        Result GetUsbTypeCPowerSourceCircuitVersion(out byte arg0);
        Result GetAnalogStickModuleTypeL(out byte arg0);
        Result GetAnalogStickModelParameterL(out AnalogStickModelParameter arg0);
        Result GetAnalogStickFactoryCalibrationL(out AnalogStickFactoryCalibration arg0);
        Result GetAnalogStickModuleTypeR(out byte arg0);
        Result GetAnalogStickModelParameterR(out AnalogStickModelParameter arg0);
        Result GetAnalogStickFactoryCalibrationR(out AnalogStickFactoryCalibration arg0);
        Result GetConsoleSixAxisSensorModuleType(out byte arg0);
        Result GetConsoleSixAxisSensorHorizontalOffset(out ConsoleSixAxisSensorHorizontalOffset arg0);
        Result GetBatteryVersion(out byte arg0);
        Result GetDeviceId(out ulong arg0);
        Result GetConsoleSixAxisSensorMountType(out byte arg0);
    }
}
