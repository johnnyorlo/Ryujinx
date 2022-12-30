using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Hidbus
{
    interface IHidbusServer : IServiceObject
    {
        Result GetBusHandle(out BusHandle arg0, out bool arg1, uint arg2, ulong arg3, AppletResourceUserId arg4);
        Result IsExternalDeviceConnected(out bool arg0, BusHandle arg1);
        Result Initialize(BusHandle arg0, AppletResourceUserId arg1);
        Result Finalize(BusHandle arg0, AppletResourceUserId arg1);
        Result EnableExternalDevice(BusHandle arg0, bool arg1, ulong arg2, AppletResourceUserId arg3);
        Result GetExternalDeviceId(out uint arg0, BusHandle arg1);
        Result SendCommandAsync(ReadOnlySpan<byte> arg0, BusHandle arg1);
        Result GetSendCommandAsynceResult(out uint arg0, Span<byte> arg1, BusHandle arg2);
        Result SetEventForSendCommandAsycResult(out int arg0, BusHandle arg1);
        Result GetSharedMemoryHandle(out int arg0);
        Result EnableJoyPollingReceiveMode(ReadOnlySpan<byte> arg0, int arg1, uint arg2, uint arg3, BusHandle arg4);
        Result DisableJoyPollingReceiveMode(BusHandle arg0);
        Result SetStatusManagerType(uint arg0);
    }
}
