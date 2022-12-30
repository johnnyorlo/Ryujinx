using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class AppletProxyCommon : IAppletProxyCommon
    {
        [CmifCommand(0)]
        public Result GetCommonStateGetter(out ICommonStateGetter arg0)
        {
            arg0 = new CommonStateGetter();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetSelfController(out ISelfController arg0)
        {
            arg0 = new SelfController();

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetWindowController(out IWindowController arg0)
        {
            arg0 = new WindowController();

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetAudioController(out IAudioController arg0)
        {
            arg0 = new AudioController();

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result GetDisplayController(out IDisplayController arg0)
        {
            arg0 = new DisplayController();

            return Result.Success;
        }

        [CmifCommand(1000)]
        public Result GetDebugFunctions(out IDebugFunctions arg0)
        {
            arg0 = new DebugFunctions();

            return Result.Success;
        }
    }
}
