using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Kpr;
using Ryujinx.Horizon.Sdk.Oe;
using Ryujinx.Horizon.Sdk.Settings.System;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Settings
{
    interface ISettingsServer : IServiceObject
    {
        Result GetLanguageCode(out LanguageCode arg0);
        Result GetAvailableLanguageCodes(out int arg0, Span<LanguageCode> arg1);
        Result MakeLanguageCode(out LanguageCode arg0, int arg1);
        Result GetAvailableLanguageCodeCount(out int arg0);
        Result GetRegionCode(out int arg0);
        Result GetAvailableLanguageCodes2(out int arg0, Span<LanguageCode> arg1);
        Result GetAvailableLanguageCodeCount2(out int arg0);
        Result GetKeyCodeMap(out KeyCodeMap arg0);
        Result GetQuestFlag(out bool arg0);
        Result GetKeyCodeMap2(out KeyCodeMap arg0);
        Result GetFirmwareVersionForDebug(out FirmwareVersionForDebug arg0);
        Result GetDeviceNickName(out DeviceNickName arg0);
    }
}
