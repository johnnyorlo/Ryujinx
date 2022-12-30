using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Audio.Detail
{
    interface IAudioDevice : IServiceObject
    {
        Result ListAudioDeviceName(Span<byte> arg0, out int arg1);
        Result SetAudioDeviceOutputVolume(ReadOnlySpan<byte> arg0, float arg1);
        Result GetAudioDeviceOutputVolume(ReadOnlySpan<byte> arg0, out float arg1);
        Result GetActiveAudioDeviceName(Span<byte> arg0);
        Result QueryAudioDeviceSystemEvent(out int arg0);
        Result GetActiveChannelCount(out int arg0);
        Result ListAudioDeviceNameAuto(Span<byte> arg0, out int arg1);
        Result SetAudioDeviceOutputVolumeAuto(ReadOnlySpan<byte> arg0, float arg1);
        Result GetAudioDeviceOutputVolumeAuto(ReadOnlySpan<byte> arg0, out float arg1);
        Result GetActiveAudioDeviceNameAuto(Span<byte> arg0);
        Result QueryAudioDeviceInputEvent(out int arg0);
        Result QueryAudioDeviceOutputEvent(out int arg0);
        Result GetActiveAudioOutputDeviceName(Span<byte> arg0);
        Result ListAudioOutputDeviceName(Span<byte> arg0, out int arg1);
    }
}
