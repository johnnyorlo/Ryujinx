using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Nsd.Detail
{
    interface IManager : IServiceObject
    {
        Result GetSettingUrl(out Url arg0);
        Result GetSettingName(out SettingName arg0);
        Result GetEnvironmentIdentifier(out EnvironmentIdentifier arg0);
        Result GetDeviceId(out DeviceId arg0);
        Result DeleteSettings(int arg0);
        Result ImportSettings(ReadOnlySpan<byte> arg0, Span<byte> arg1, int arg2);
        Result SetChangeEnvironmentIdentifierDisabled(bool arg0);
        Result Resolve(out Fqdn arg0, in Fqdn arg1);
        Result ResolveEx(out InnerResult arg0, out Fqdn arg1, in Fqdn arg2);
        Result GetNasServiceSetting(out NasServiceSetting arg0, in NasServiceName arg1);
        Result GetNasServiceSettingEx(out InnerResult arg0, out NasServiceSetting arg1, in NasServiceName arg2);
        Result GetNasRequestFqdn(out Fqdn arg0);
        Result GetNasRequestFqdnEx(out InnerResult arg0, out Fqdn arg1);
        Result GetNasApiFqdn(out Fqdn arg0);
        Result GetNasApiFqdnEx(out InnerResult arg0, out Fqdn arg1);
        Result GetCurrentSetting(out SaveData arg0);
        Result WriteTestParameter(ReadOnlySpan<byte> arg0);
        Result ReadTestParameter(Span<byte> arg0);
        Result ReadSaveDataFromFsForTest(out SaveData arg0);
        Result WriteSaveDataToFsForTest(in SaveData arg0);
        Result DeleteSaveDataOfFsForTest();
        Result IsChangeEnvironmentIdentifierDisabled(out bool arg0);
        Result SetWithoutDomainExchangeFqdns(ReadOnlySpan<Fqdn> arg0);
        Result GetApplicationServerEnvironmentType(out byte arg0);
        Result SetApplicationServerEnvironmentType(byte arg0);
        Result DeleteApplicationServerEnvironmentType();
    }
}
