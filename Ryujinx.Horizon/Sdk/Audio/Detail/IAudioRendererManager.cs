using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Audio.Detail
{
    interface IAudioRendererManager : IServiceObject
    {
        Result OpenAudioRenderer(out IAudioRenderer arg0, AudioRendererParameterInternal arg1, int arg2, int arg3, ulong arg4, AppletResourceUserId arg5);
        Result GetWorkBufferSize(out long arg0, AudioRendererParameterInternal arg1);
        Result GetAudioDeviceService(out IAudioDevice arg0, AppletResourceUserId arg1);
        Result OpenAudioRendererForManualExecution(out IAudioRenderer arg0, AudioRendererParameterInternal arg1, ulong arg2, int arg3, ulong arg4, AppletResourceUserId arg5);
        Result GetAudioDeviceServiceWithRevisionInfo(out IAudioDevice arg0, AppletResourceUserId arg1, uint arg2);
    }
}
