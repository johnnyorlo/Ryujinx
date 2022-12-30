using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IAudioController : IServiceObject
    {
        Result SetExpectedMasterVolume(float arg0, float arg1);
        Result GetMainAppletExpectedMasterVolume(out float arg0);
        Result GetLibraryAppletExpectedMasterVolume(out float arg0);
        Result ChangeMainAppletMasterVolume(float arg0, long arg1);
        Result SetTransparentVolumeRate(float arg0);
    }
}
