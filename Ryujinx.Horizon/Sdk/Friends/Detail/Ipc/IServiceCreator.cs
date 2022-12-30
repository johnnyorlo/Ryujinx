using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Friends.Detail.Ipc
{
    interface IServiceCreator : IServiceObject
    {
        Result CreateFriendService(out IFriendService arg0);
        Result CreateNotificationService(out INotificationService arg0, Uid arg1);
        Result CreateDaemonSuspendSessionService(out IDaemonSuspendSessionService arg0);
    }
}
