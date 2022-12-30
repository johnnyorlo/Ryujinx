using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Notification.Server
{
    class NotificationServicesCommon : INotificationServicesCommon
    {
        [CmifCommand(500)]
        public Result RegisterAlarmSetting(out AlarmSettingId arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x40)] AlarmSetting arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(510)]
        public Result UpdateAlarmSetting([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x40)] AlarmSetting arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(520)]
        public Result ListAlarmSettings(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<AlarmSetting> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(530)]
        public Result LoadApplicationParameter(out uint arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1, AlarmSettingId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(540)]
        public Result DeleteAlarmSetting(AlarmSettingId arg0)
        {
            return Result.Success;
        }
    }
}
