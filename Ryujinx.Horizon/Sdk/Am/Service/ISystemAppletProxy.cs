using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface ISystemAppletProxy : IServiceObject
    {
        Result GetHomeMenuFunctions(out IHomeMenuFunctions arg0);
        Result GetGlobalStateController(out IGlobalStateController arg0);
        Result GetApplicationCreator(out IApplicationCreator arg0);
        Result GetAppletCommonFunctions(out IAppletCommonFunctions arg0);
    }
}
