using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Friends.Detail.Ipc
{
    class NotificationService : INotificationService
    {
        [CmifCommand(0)]
        public Result GetEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result Clear()
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result Pop(out SizedNotificationInfo arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
