using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Npns
{
    interface INotificationReceiver : IServiceObject
    {
        Result ListenTo(ApplicationId arg0);
        Result ListenToMyApplicationId(ulong arg0);
        Result Receive(Span<byte> arg0, ushort arg1);
        Result GetReceiveEvent(out int arg0);
    }
}
