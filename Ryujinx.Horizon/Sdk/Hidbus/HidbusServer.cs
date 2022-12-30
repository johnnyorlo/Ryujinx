using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Hidbus
{
    class HidbusServer : IHidbusServer
    {
        [CmifCommand(1)]
        public Result GetBusHandle(out BusHandle arg0, out bool arg1, uint arg2, ulong arg3, AppletResourceUserId arg4)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result IsExternalDeviceConnected(out bool arg0, BusHandle arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result Initialize(BusHandle arg0, AppletResourceUserId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result Finalize(BusHandle arg0, AppletResourceUserId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(5)]
        public Result EnableExternalDevice(BusHandle arg0, bool arg1, ulong arg2, AppletResourceUserId arg3)
        {
            return Result.Success;
        }

        [CmifCommand(6)]
        public Result GetExternalDeviceId(out uint arg0, BusHandle arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(7)]
        public Result SendCommandAsync([Buffer(HipcBufferFlags.In | HipcBufferFlags.AutoSelect)] ReadOnlySpan<byte> arg0, BusHandle arg1)
        {
            return Result.Success;
        }

        [CmifCommand(8)]
        public Result GetSendCommandAsynceResult(out uint arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.AutoSelect)] Span<byte> arg1, BusHandle arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(9)]
        public Result SetEventForSendCommandAsycResult([CopyHandle] out int arg0, BusHandle arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result GetSharedMemoryHandle([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(11)]
        public Result EnableJoyPollingReceiveMode([Buffer(HipcBufferFlags.In | HipcBufferFlags.AutoSelect)] ReadOnlySpan<byte> arg0, [CopyHandle] int arg1, uint arg2, uint arg3, BusHandle arg4)
        {
            return Result.Success;
        }

        [CmifCommand(12)]
        public Result DisableJoyPollingReceiveMode(BusHandle arg0)
        {
            return Result.Success;
        }

        [CmifCommand(14)]
        public Result SetStatusManagerType(uint arg0)
        {
            return Result.Success;
        }
    }
}
