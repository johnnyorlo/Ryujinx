using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IAppletProxyCommon : IServiceObject
    {
        Result GetCommonStateGetter(out ICommonStateGetter arg0);
        Result GetSelfController(out ISelfController arg0);
        Result GetWindowController(out IWindowController arg0);
        Result GetAudioController(out IAudioController arg0);
        Result GetDisplayController(out IDisplayController arg0);
        Result GetDebugFunctions(out IDebugFunctions arg0);
    }
}
