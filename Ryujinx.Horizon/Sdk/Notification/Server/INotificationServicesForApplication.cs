using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Notification.Server
{
    interface INotificationServicesForApplication : IServiceObject
    {
        Result Initialize(ulong arg0, ulong pid);
    }
}
