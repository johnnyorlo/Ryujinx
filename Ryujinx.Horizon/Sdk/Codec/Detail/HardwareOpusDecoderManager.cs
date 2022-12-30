using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;

namespace Ryujinx.Horizon.Sdk.Codec.Detail
{
    class HardwareOpusDecoderManager : IHardwareOpusDecoderManager
    {
        [CmifCommand(0)]
        public Result OpenHardwareOpusDecoder(out IHardwareOpusDecoder arg0, HardwareOpusDecoderParameterInternal arg1, [CopyHandle] int arg2, int arg3)
        {
            arg0 = new HardwareOpusDecoder();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetWorkBufferSize(out int arg0, HardwareOpusDecoderParameterInternal arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result OpenHardwareOpusDecoderForMultiStream(out IHardwareOpusDecoder arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x110)] in HardwareOpusMultiStreamDecoderParameterInternal arg1, [CopyHandle] int arg2, int arg3)
        {
            arg0 = new HardwareOpusDecoder();

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetWorkBufferSizeForMultiStream(out int arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x110)] in HardwareOpusMultiStreamDecoderParameterInternal arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result OpenHardwareOpusDecoderEx(out IHardwareOpusDecoder arg0, HardwareOpusDecoderParameterInternalEx arg1, [CopyHandle] int arg2, int arg3)
        {
            arg0 = new HardwareOpusDecoder();

            return Result.Success;
        }

        [CmifCommand(5)]
        public Result GetWorkBufferSizeEx(out int arg0, HardwareOpusDecoderParameterInternalEx arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(6)]
        public Result OpenHardwareOpusDecoderForMultiStreamEx(out IHardwareOpusDecoder arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x118)] in HardwareOpusMultiStreamDecoderParameterInternalEx arg1, [CopyHandle] int arg2, int arg3)
        {
            arg0 = new HardwareOpusDecoder();

            return Result.Success;
        }

        [CmifCommand(7)]
        public Result GetWorkBufferSizeForMultiStreamEx(out int arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x118)] in HardwareOpusMultiStreamDecoderParameterInternalEx arg1)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
