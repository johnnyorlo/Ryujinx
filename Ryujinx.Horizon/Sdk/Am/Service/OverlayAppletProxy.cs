using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class OverlayAppletProxy : IOverlayAppletProxy
    {
        [CmifCommand(20)]
        public Result GetOverlayFunctions(out IOverlayFunctions arg0)
        {
            arg0 = new OverlayFunctions();

            return Result.Success;
        }

        [CmifCommand(21)]
        public Result GetAppletCommonFunctions(out IAppletCommonFunctions arg0)
        {
            arg0 = new AppletCommonFunctions();

            return Result.Success;
        }
    }
}
