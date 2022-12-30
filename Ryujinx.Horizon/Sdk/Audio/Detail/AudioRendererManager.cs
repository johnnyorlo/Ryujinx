using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Audio.Detail
{
    class AudioRendererManager : IAudioRendererManager
    {
        // Could not determine command ID, please fill it in manually
        public Result OpenAudioRenderer(out IAudioRenderer arg0, AudioRendererParameterInternal arg1, int arg2, int arg3, ulong arg4, AppletResourceUserId arg5)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result GetWorkBufferSize(out long arg0, AudioRendererParameterInternal arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result GetAudioDeviceService(out IAudioDevice arg0, AppletResourceUserId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result OpenAudioRendererForManualExecution(out IAudioRenderer arg0, AudioRendererParameterInternal arg1, ulong arg2, int arg3, ulong arg4, AppletResourceUserId arg5)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result GetAudioDeviceServiceWithRevisionInfo(out IAudioDevice arg0, AppletResourceUserId arg1, uint arg2)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
