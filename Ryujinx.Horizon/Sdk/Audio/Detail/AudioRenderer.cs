using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Audio.Detail
{
    class AudioRenderer : IAudioRenderer
    {
        // Could not determine command ID, please fill it in manually
        public Result GetSampleRate(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result GetSampleCount(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result GetMixBufferCount(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result GetState(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result RequestUpdate(Span<byte> arg0, Span<byte> arg1, ReadOnlySpan<byte> arg2)
        {
            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result Start()
        {
            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result Stop()
        {
            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result QuerySystemEvent(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result SetRenderingTimeLimit(int arg0)
        {
            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result GetRenderingTimeLimit(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result RequestUpdateAuto(Span<byte> arg0, Span<byte> arg1, ReadOnlySpan<byte> arg2)
        {
            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result ExecuteAudioRendererRendering()
        {
            return Result.Success;
        }
    }
}
