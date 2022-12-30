using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Notification.Server
{
    interface INotificationServicesCommon : IServiceObject
    {
        Result RegisterAlarmSetting(out AlarmSettingId arg0, AlarmSetting arg1, ReadOnlySpan<byte> arg2);
        Result UpdateAlarmSetting(AlarmSetting arg0, ReadOnlySpan<byte> arg1);
        Result ListAlarmSettings(out int arg0, Span<AlarmSetting> arg1);
        Result LoadApplicationParameter(out uint arg0, Span<byte> arg1, AlarmSettingId arg2);
        Result DeleteAlarmSetting(AlarmSettingId arg0);
    }
}
