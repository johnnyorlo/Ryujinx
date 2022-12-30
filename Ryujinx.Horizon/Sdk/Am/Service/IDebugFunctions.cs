using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Ns;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IDebugFunctions : IServiceObject
    {
        Result NotifyMessageToHomeMenuForDebug(AppletMessage arg0);
        Result PerformSystemButtonPressing(SystemButtonType arg0);
        Result InvalidateTransitionLayer();
        Result RequestLaunchApplicationWithUserAndArgumentForDebug(ApplicationId arg0, ReadOnlySpan<Uid> arg1, bool arg2, ReadOnlySpan<byte> arg3);
        Result RequestLaunchApplicationByApplicationLaunchInfoForDebug(ApplicationLaunchInfo arg0, ReadOnlySpan<Uid> arg1, bool arg2, ReadOnlySpan<byte> arg3);
        Result GetAppletResourceUsageInfo(out AppletResourceUsageInfo arg0);
        Result SetCpuBoostModeForDebug(int arg0);
        Result CancelCpuBoostModeForDebug();
        Result PushToAppletBoundChannelForDebug(IStorage arg0, int arg1);
        Result TryPopFromAppletBoundChannelForDebug(out IStorage arg0, int arg1);
        Result AlarmSettingNotificationEnableAppEventReserve(IStorage arg0, ApplicationId arg1);
        Result AlarmSettingNotificationDisableAppEventReserve();
        Result AlarmSettingNotificationPushAppEventNotify(IStorage arg0);
        Result FriendInvitationSetApplicationParameter(IStorage arg0, ApplicationId arg1);
        Result FriendInvitationClearApplicationParameter();
        Result FriendInvitationPushApplicationParameter(IStorage arg0);
        Result RestrictPowerOperationForSecureLaunchModeForDebug();
        Result GetGrcProcessLaunchedSystemEvent(out int arg0);
    }
}
