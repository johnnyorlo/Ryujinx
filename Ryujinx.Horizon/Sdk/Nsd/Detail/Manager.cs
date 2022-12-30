using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Nsd.Detail
{
    class Manager : IManager
    {
        [CmifCommand(5)]
        public Result GetSettingUrl([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x100)] out Url arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result GetSettingName([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x100)] out SettingName arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(11)]
        public Result GetEnvironmentIdentifier([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x8)] out EnvironmentIdentifier arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(12)]
        public Result GetDeviceId(out DeviceId arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(13)]
        public Result DeleteSettings(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(14)]
        public Result ImportSettings([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1, int arg2)
        {
            return Result.Success;
        }

        [CmifCommand(15)]
        public Result SetChangeEnvironmentIdentifierDisabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(20)]
        public Result Resolve([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x100)] out Fqdn arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x100)] in Fqdn arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(21)]
        public Result ResolveEx(out InnerResult arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x100)] out Fqdn arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x100)] in Fqdn arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(30)]
        public Result GetNasServiceSetting([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x108)] out NasServiceSetting arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x10)] in NasServiceName arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(31)]
        public Result GetNasServiceSettingEx(out InnerResult arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x108)] out NasServiceSetting arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x10)] in NasServiceName arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(40)]
        public Result GetNasRequestFqdn([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x100)] out Fqdn arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(41)]
        public Result GetNasRequestFqdnEx(out InnerResult arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x100)] out Fqdn arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(42)]
        public Result GetNasApiFqdn([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x100)] out Fqdn arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(43)]
        public Result GetNasApiFqdnEx(out InnerResult arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x100)] out Fqdn arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(50)]
        public Result GetCurrentSetting([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x2BF0)] out SaveData arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(51)]
        public Result WriteTestParameter([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(52)]
        public Result ReadTestParameter([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(60)]
        public Result ReadSaveDataFromFsForTest([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x2BF0)] out SaveData arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(61)]
        public Result WriteSaveDataToFsForTest([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x2BF0)] in SaveData arg0)
        {
            return Result.Success;
        }

        [CmifCommand(62)]
        public Result DeleteSaveDataOfFsForTest()
        {
            return Result.Success;
        }

        [CmifCommand(63)]
        public Result IsChangeEnvironmentIdentifierDisabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(64)]
        public Result SetWithoutDomainExchangeFqdns([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<Fqdn> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(100)]
        public Result GetApplicationServerEnvironmentType(out byte arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(101)]
        public Result SetApplicationServerEnvironmentType(byte arg0)
        {
            return Result.Success;
        }

        [CmifCommand(102)]
        public Result DeleteApplicationServerEnvironmentType()
        {
            return Result.Success;
        }
    }
}
