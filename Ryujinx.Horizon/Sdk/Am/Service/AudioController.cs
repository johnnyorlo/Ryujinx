using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class AudioController : IAudioController
    {
        [CmifCommand(0)]
        public Result SetExpectedMasterVolume(float arg0, float arg1)
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetMainAppletExpectedMasterVolume(out float arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetLibraryAppletExpectedMasterVolume(out float arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result ChangeMainAppletMasterVolume(float arg0, long arg1)
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result SetTransparentVolumeRate(float arg0)
        {
            return Result.Success;
        }
    }
}
