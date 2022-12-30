using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Nifm.Detail.Sf;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Util;
using System;

namespace Ryujinx.Horizon.Sdk.Nifm.Detail
{
    interface IGeneralService : IServiceObject
    {
        Result GetClientId(out ClientId arg0);
        Result CreateScanRequest(out IScanRequest arg0);
        Result CreateRequest(out IRequest arg0, int arg1);
        Result GetCurrentNetworkProfile(out NetworkProfileData arg0);
        Result EnumerateNetworkInterfaces(Span<NetworkInterfaceInfo> arg0, out int arg1, uint arg2);
        Result EnumerateNetworkProfiles(Span<NetworkProfileBasicInfo> arg0, out int arg1, byte arg2);
        Result GetNetworkProfile(out NetworkProfileData arg0, Uuid arg1);
        Result SetNetworkProfile(out Uuid arg0, NetworkProfileData arg1);
        Result RemoveNetworkProfile(Uuid arg0);
        Result GetScanDataV0(Span<AccessPointDataV0> arg0, out int arg1);
        Result GetCurrentIpAddress(out IpV4Address arg0);
        Result GetCurrentAccessPointV0(out AccessPointDataV0 arg0);
        Result CreateTemporaryNetworkProfile(out INetworkProfile arg0, out Uuid arg1, NetworkProfileData arg2);
        Result GetCurrentIpConfigInfo(out IpAddressSetting arg0, out DnsSetting arg1);
        Result SetWirelessCommunicationEnabled(bool arg0);
        Result IsWirelessCommunicationEnabled(out bool arg0);
        Result GetInternetConnectionStatus(out InternetConnectionStatus arg0);
        Result SetEthernetCommunicationEnabled(bool arg0);
        Result IsEthernetCommunicationEnabled(out bool arg0);
        Result IsAnyInternetRequestAccepted(out bool arg0, ClientId arg1);
        Result IsAnyForegroundRequestAccepted(out bool arg0);
        Result PutToSleep();
        Result WakeUp();
        Result GetSsidListVersion(out SsidListVersion arg0);
        Result SetExclusiveClient(ClientId arg0);
        Result GetDefaultIpSetting(out IpSettingData arg0);
        Result SetDefaultIpSetting(IpSettingData arg0);
        Result SetWirelessCommunicationEnabledForTest(bool arg0);
        Result SetEthernetCommunicationEnabledForTest(bool arg0);
        Result GetTelemetrySystemEventReadableHandle(out int arg0);
        Result GetTelemetryInfo(out TelemetryInfo arg0);
        Result ConfirmSystemAvailability();
        Result SetBackgroundRequestEnabled(bool arg0);
        Result GetScanDataV1(Span<AccessPointDataV1> arg0, out int arg1);
        Result GetCurrentAccessPointV1(out AccessPointDataV1 arg0);
        Result Shutdown();
        Result GetAllowedChannels(Span<short> arg0, out int arg1);
        Result NotifyApplicationRightsInvalidated(ulong arg0);
        Result SetAcceptableNetworkTypeFlag(uint arg0);
        Result GetAcceptableNetworkTypeFlag(out uint arg0);
        Result NotifyConnectionStateChanged();
        Result SetWowlDelayedWakeTime(int arg0);
    }
}
