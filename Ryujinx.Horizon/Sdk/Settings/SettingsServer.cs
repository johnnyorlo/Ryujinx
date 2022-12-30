using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Kpr;
using Ryujinx.Horizon.Sdk.Oe;
using Ryujinx.Horizon.Sdk.Settings.System;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Settings
{
    class SettingsServer : ISettingsServer
    {
        [CmifCommand(0)]
        public Result GetLanguageCode(out LanguageCode arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetAvailableLanguageCodes(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<LanguageCode> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result MakeLanguageCode(out LanguageCode arg0, int arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetAvailableLanguageCodeCount(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result GetRegionCode(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(5)]
        public Result GetAvailableLanguageCodes2(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<LanguageCode> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(6)]
        public Result GetAvailableLanguageCodeCount2(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(7)]
        public Result GetKeyCodeMap([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x1000)] out KeyCodeMap arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8)]
        public Result GetQuestFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(9)]
        public Result GetKeyCodeMap2([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x1000)] out KeyCodeMap arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result GetFirmwareVersionForDebug([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x80)] out FirmwareVersionForDebug arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(11)]
        public Result GetDeviceNickName([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x80)] out DeviceNickName arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
