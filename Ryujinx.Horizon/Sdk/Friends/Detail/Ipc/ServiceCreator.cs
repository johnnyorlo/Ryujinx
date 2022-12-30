using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Friends.Detail.Ipc
{
    class ServiceCreator : IServiceCreator
    {
        [CmifCommand(0)]
        public Result CreateFriendService(out IFriendService arg0)
        {
            arg0 = new FriendService();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result CreateNotificationService(out INotificationService arg0, Uid arg1)
        {
            arg0 = new NotificationService();

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result CreateDaemonSuspendSessionService(out IDaemonSuspendSessionService arg0)
        {
            arg0 = new DaemonSuspendSessionService();

            return Result.Success;
        }
    }
}
