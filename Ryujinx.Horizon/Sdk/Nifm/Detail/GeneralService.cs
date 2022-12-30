using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Nifm.Detail.Sf;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using Ryujinx.Horizon.Sdk.Util;
using System;

namespace Ryujinx.Horizon.Sdk.Nifm.Detail
{
    class GeneralService : IGeneralService
    {
        [CmifCommand(1)]
        public Result GetClientId([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x4)] out ClientId arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result CreateScanRequest(out IScanRequest arg0)
        {
            arg0 = new ScanRequest();

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result CreateRequest(out IRequest arg0, int arg1)
        {
            arg0 = new Request();

            return Result.Success;
        }

        [CmifCommand(5)]
        public Result GetCurrentNetworkProfile([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x17C)] out NetworkProfileData arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(6)]
        public Result EnumerateNetworkInterfaces([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<NetworkInterfaceInfo> arg0, out int arg1, uint arg2)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(7)]
        public Result EnumerateNetworkProfiles([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<NetworkProfileBasicInfo> arg0, out int arg1, byte arg2)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(8)]
        public Result GetNetworkProfile([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x17C)] out NetworkProfileData arg0, Uuid arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(9)]
        public Result SetNetworkProfile(out Uuid arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x17C)] in NetworkProfileData arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result RemoveNetworkProfile(Uuid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result GetScanDataV0([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<AccessPointDataV0> arg0, out int arg1)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(12)]
        public Result GetCurrentIpAddress(out IpV4Address arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(13)]
        public Result GetCurrentAccessPointV0([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x34)] out AccessPointDataV0 arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(14)]
        public Result CreateTemporaryNetworkProfile(out INetworkProfile arg0, out Uuid arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x17C)] in NetworkProfileData arg2)
        {
            arg0 = new NetworkProfile();
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(15)]
        public Result GetCurrentIpConfigInfo(out IpAddressSetting arg0, out DnsSetting arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(16)]
        public Result SetWirelessCommunicationEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(17)]
        public Result IsWirelessCommunicationEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(18)]
        public Result GetInternetConnectionStatus(out InternetConnectionStatus arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(19)]
        public Result SetEthernetCommunicationEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(20)]
        public Result IsEthernetCommunicationEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(21)]
        public Result IsAnyInternetRequestAccepted(out bool arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x4)] in ClientId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(22)]
        public Result IsAnyForegroundRequestAccepted(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(23)]
        public Result PutToSleep()
        {
            return Result.Success;
        }

        [CmifCommand(24)]
        public Result WakeUp()
        {
            return Result.Success;
        }

        [CmifCommand(25)]
        public Result GetSsidListVersion(out SsidListVersion arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(26)]
        public Result SetExclusiveClient([Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x4)] in ClientId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(27)]
        public Result GetDefaultIpSetting([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0xC2)] out IpSettingData arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(28)]
        public Result SetDefaultIpSetting([Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0xC2)] in IpSettingData arg0)
        {
            return Result.Success;
        }

        [CmifCommand(29)]
        public Result SetWirelessCommunicationEnabledForTest(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(30)]
        public Result SetEthernetCommunicationEnabledForTest(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(31)]
        public Result GetTelemetrySystemEventReadableHandle([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(32)]
        public Result GetTelemetryInfo([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x620)] out TelemetryInfo arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(33)]
        public Result ConfirmSystemAvailability()
        {
            return Result.Success;
        }

        [CmifCommand(34)]
        public Result SetBackgroundRequestEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(35)]
        public Result GetScanDataV1([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<AccessPointDataV1> arg0, out int arg1)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(36)]
        public Result GetCurrentAccessPointV1([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x34)] out AccessPointDataV1 arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(37)]
        public Result Shutdown()
        {
            return Result.Success;
        }

        [CmifCommand(38)]
        public Result GetAllowedChannels([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<short> arg0, out int arg1)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(39)]
        public Result NotifyApplicationRightsInvalidated(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(40)]
        public Result SetAcceptableNetworkTypeFlag(uint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(41)]
        public Result GetAcceptableNetworkTypeFlag(out uint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(42)]
        public Result NotifyConnectionStateChanged()
        {
            return Result.Success;
        }

        [CmifCommand(43)]
        public Result SetWowlDelayedWakeTime(int arg0)
        {
            return Result.Success;
        }
    }
}
