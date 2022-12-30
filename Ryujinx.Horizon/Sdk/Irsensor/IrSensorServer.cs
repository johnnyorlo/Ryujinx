using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Irsensor
{
    class IrSensorServer : IIrSensorServer
    {
        [CmifCommand(302)]
        public Result ActivateIrsensor(AppletResourceUserId arg0, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(303)]
        public Result DeactivateIrsensor(AppletResourceUserId arg0, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(304)]
        public Result GetIrsensorSharedMemoryHandle([CopyHandle] out int arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(305)]
        public Result StopImageProcessor(AppletResourceUserId arg0, IrCameraHandle arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(306)]
        public Result RunMomentProcessor(AppletResourceUserId arg0, IrCameraHandle arg1, PackedMomentProcessorConfig arg2, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(307)]
        public Result RunClusteringProcessor(AppletResourceUserId arg0, IrCameraHandle arg1, PackedClusteringProcessorConfig arg2, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(308)]
        public Result RunImageTransferProcessor(AppletResourceUserId arg0, IrCameraHandle arg1, PackedImageTransferProcessorConfig arg2, [CopyHandle] int arg3, ulong arg4, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(309)]
        public Result GetImageTransferProcessorState(AppletResourceUserId arg0, out ImageTransferProcessorState arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg2, IrCameraHandle arg3, [ClientProcessId] ulong pid)
        {
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(310)]
        public Result RunTeraPluginProcessor(AppletResourceUserId arg0, IrCameraHandle arg1, PackedTeraPluginProcessorConfig arg2, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(311)]
        public Result GetNpadIrCameraHandle(out IrCameraHandle arg0, uint arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(312)]
        public Result RunPointingProcessor(AppletResourceUserId arg0, IrCameraHandle arg1, PackedPointingProcessorConfig arg2, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(313)]
        public Result SuspendImageProcessor(AppletResourceUserId arg0, IrCameraHandle arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(314)]
        public Result CheckFirmwareVersion(AppletResourceUserId arg0, IrCameraHandle arg1, PackedMcuVersion arg2, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(315)]
        public Result SetFunctionLevel(AppletResourceUserId arg0, IrCameraHandle arg1, PackedFunctionLevel arg2, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(316)]
        public Result RunImageTransferExProcessor(AppletResourceUserId arg0, IrCameraHandle arg1, PackedImageTransferProcessorExConfig arg2, [CopyHandle] int arg3, ulong arg4, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(317)]
        public Result RunIrLedProcessor(AppletResourceUserId arg0, IrCameraHandle arg1, PackedIrLedProcessorConfig arg2, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(318)]
        public Result StopImageProcessorAsync(AppletResourceUserId arg0, IrCameraHandle arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(319)]
        public Result ActivateIrsensorWithFunctionLevel(AppletResourceUserId arg0, PackedFunctionLevel arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }
    }
}
