using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Audio.Detail
{
    class AudioDevice : IAudioDevice
    {
        // Could not determine command ID, please fill it in manually
        public Result ListAudioDeviceName(Span<byte> arg0, out int arg1)
        {
            arg1 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result SetAudioDeviceOutputVolume(ReadOnlySpan<byte> arg0, float arg1)
        {
            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result GetAudioDeviceOutputVolume(ReadOnlySpan<byte> arg0, out float arg1)
        {
            arg1 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result GetActiveAudioDeviceName(Span<byte> arg0)
        {
            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result QueryAudioDeviceSystemEvent(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result GetActiveChannelCount(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result ListAudioDeviceNameAuto(Span<byte> arg0, out int arg1)
        {
            arg1 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result SetAudioDeviceOutputVolumeAuto(ReadOnlySpan<byte> arg0, float arg1)
        {
            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result GetAudioDeviceOutputVolumeAuto(ReadOnlySpan<byte> arg0, out float arg1)
        {
            arg1 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result GetActiveAudioDeviceNameAuto(Span<byte> arg0)
        {
            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result QueryAudioDeviceInputEvent(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result QueryAudioDeviceOutputEvent(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result GetActiveAudioOutputDeviceName(Span<byte> arg0)
        {
            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result ListAudioOutputDeviceName(Span<byte> arg0, out int arg1)
        {
            arg1 = default;

            return Result.Success;
        }
    }
}
