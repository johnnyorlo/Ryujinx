using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Ns;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class DebugFunctions : IDebugFunctions
    {
        [CmifCommand(0)]
        public Result NotifyMessageToHomeMenuForDebug(AppletMessage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(10)]
        public Result PerformSystemButtonPressing(SystemButtonType arg0)
        {
            return Result.Success;
        }

        [CmifCommand(20)]
        public Result InvalidateTransitionLayer()
        {
            return Result.Success;
        }

        [CmifCommand(30)]
        public Result RequestLaunchApplicationWithUserAndArgumentForDebug(ApplicationId arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<Uid> arg1, bool arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg3)
        {
            return Result.Success;
        }

        [CmifCommand(31)]
        public Result RequestLaunchApplicationByApplicationLaunchInfoForDebug(ApplicationLaunchInfo arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<Uid> arg1, bool arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg3)
        {
            return Result.Success;
        }

        [CmifCommand(40)]
        public Result GetAppletResourceUsageInfo(out AppletResourceUsageInfo arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(100)]
        public Result SetCpuBoostModeForDebug(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(101)]
        public Result CancelCpuBoostModeForDebug()
        {
            return Result.Success;
        }

        [CmifCommand(110)]
        public Result PushToAppletBoundChannelForDebug(IStorage arg0, int arg1)
        {
            return Result.Success;
        }

        [CmifCommand(111)]
        public Result TryPopFromAppletBoundChannelForDebug(out IStorage arg0, int arg1)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(120)]
        public Result AlarmSettingNotificationEnableAppEventReserve(IStorage arg0, ApplicationId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(121)]
        public Result AlarmSettingNotificationDisableAppEventReserve()
        {
            return Result.Success;
        }

        [CmifCommand(122)]
        public Result AlarmSettingNotificationPushAppEventNotify(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(130)]
        public Result FriendInvitationSetApplicationParameter(IStorage arg0, ApplicationId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(131)]
        public Result FriendInvitationClearApplicationParameter()
        {
            return Result.Success;
        }

        [CmifCommand(132)]
        public Result FriendInvitationPushApplicationParameter(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(140)]
        public Result RestrictPowerOperationForSecureLaunchModeForDebug()
        {
            return Result.Success;
        }

        [CmifCommand(900)]
        public Result GetGrcProcessLaunchedSystemEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
