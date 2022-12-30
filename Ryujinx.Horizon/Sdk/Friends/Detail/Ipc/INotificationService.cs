using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Friends.Detail.Ipc
{
    interface INotificationService : IServiceObject
    {
        Result GetEvent(out int arg0);
        Result Clear();
        Result Pop(out SizedNotificationInfo arg0);
    }
}
