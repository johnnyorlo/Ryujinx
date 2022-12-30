using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IOverlayAppletProxy : IServiceObject
    {
        Result GetOverlayFunctions(out IOverlayFunctions arg0);
        Result GetAppletCommonFunctions(out IAppletCommonFunctions arg0);
    }
}
