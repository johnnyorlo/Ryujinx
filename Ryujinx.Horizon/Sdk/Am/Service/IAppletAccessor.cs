using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IAppletAccessor : IServiceObject
    {
        Result GetIntegratedAppletPointer(out IntegratedApplet arg0);
        Result GetAppletStateChangedEvent(out int arg0);
        Result IsCompleted(out bool arg0);
        Result Start();
        Result RequestExit();
        Result Terminate();
        Result GetResult();
    }
}
