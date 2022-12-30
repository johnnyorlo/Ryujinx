using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Notification.Server
{
    class NotificationServicesForApplication : INotificationServicesForApplication
    {
        [CmifCommand(1000)]
        public Result Initialize(ulong arg0, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }
    }
}
