using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Audio.Detail
{
    interface IAudioRenderer : IServiceObject
    {
        Result GetSampleRate(out int arg0);
        Result GetSampleCount(out int arg0);
        Result GetMixBufferCount(out int arg0);
        Result GetState(out int arg0);
        Result RequestUpdate(Span<byte> arg0, Span<byte> arg1, ReadOnlySpan<byte> arg2);
        Result Start();
        Result Stop();
        Result QuerySystemEvent(out int arg0);
        Result SetRenderingTimeLimit(int arg0);
        Result GetRenderingTimeLimit(out int arg0);
        Result RequestUpdateAuto(Span<byte> arg0, Span<byte> arg1, ReadOnlySpan<byte> arg2);
        Result ExecuteAudioRendererRendering();
    }
}
