using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Settings.System;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Settings
{
    interface IFirmwareDebugSettingsServer : IServiceObject
    {
        Result SetSettingsItemValue(in SettingsName arg0, in SettingsItemKey arg1, ReadOnlySpan<byte> arg2);
        Result ResetSettingsItemValue(in SettingsName arg0, in SettingsItemKey arg1);
        Result CreateSettingsItemKeyIterator(out ISettingsItemKeyIterator arg0, in SettingsName arg1);
        Result ReadSettings(out ulong arg0, Span<byte> arg1, int arg2);
        Result ResetSettings(int arg0);
        Result SetWebInspectorFlag(bool arg0);
        Result SetAllowedSslHosts(ReadOnlySpan<AllowedSslHost> arg0);
        Result SetHostFsMountPoint(in HostFsMountPoint arg0);
        Result SetMemoryUsageRateFlag(bool arg0);
    }
}
