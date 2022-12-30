using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Settings.System;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Settings
{
    class FirmwareDebugSettingsServer : IFirmwareDebugSettingsServer
    {
        [CmifCommand(2)]
        public Result SetSettingsItemValue([Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] in SettingsName arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] in SettingsItemKey arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2)
        {
            return Result.Success;
        }

        [CmifCommand(3)]
        public Result ResetSettingsItemValue([Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] in SettingsName arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] in SettingsItemKey arg1)
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result CreateSettingsItemKeyIterator(out ISettingsItemKeyIterator arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] in SettingsName arg1)
        {
            arg0 = new SettingsItemKeyIterator();

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result ReadSettings(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1, int arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(11)]
        public Result ResetSettings(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(20)]
        public Result SetWebInspectorFlag(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(21)]
        public Result SetAllowedSslHosts([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<AllowedSslHost> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(22)]
        public Result SetHostFsMountPoint([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x100)] in HostFsMountPoint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(23)]
        public Result SetMemoryUsageRateFlag(bool arg0)
        {
            return Result.Success;
        }
    }
}
