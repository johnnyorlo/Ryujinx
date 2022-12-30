using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Npns
{
    interface INpnsUser : IServiceObject
    {
        Result ListenAll();
        Result ListenTo(ApplicationId arg0);
        Result Receive(Span<byte> arg0, ushort arg1);
        Result ReceiveRaw(Span<byte> arg0, ushort arg1);
        Result GetReceiveEvent(out int arg0);
        Result GetStateChangeEvent(out int arg0);
        Result CreateToken(out NotificationToken arg0, Uid arg1, ulong arg2, ulong pid);
        Result DestroyToken(Uid arg0, ulong arg1, ulong pid);
        Result QueryIsTokenValid(out bool arg0, NotificationToken arg1);
        Result ListenToMyApplicationId(ulong arg0, ulong pid);
        Result Suspend();
        Result Resume();
        Result GetState(out int arg0);
        Result GetStatistics(Span<byte> arg0);
        Result GetJid(Span<sbyte> arg0);
        Result CreateNotificationReceiver(out INotificationReceiver arg0);
        Result GetStateWithHandover(out int arg0);
        Result GetStateChangeEventWithHandover(out int arg0);
        Result GetDropEventWithHandover(out int arg0);
        Result CreateTokenAsync(out ICreateTokenAsyncContext arg0, Uid arg1, ulong arg2, ulong pid);
    }
}
