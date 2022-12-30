using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Npns
{
    interface ICreateTokenAsyncContext : IServiceObject
    {
        Result GetNotificationToken(out NotificationToken arg0);
    }
}
