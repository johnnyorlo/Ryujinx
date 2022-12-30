using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class SystemAppletProxy : ISystemAppletProxy
    {
        [CmifCommand(20)]
        public Result GetHomeMenuFunctions(out IHomeMenuFunctions arg0)
        {
            arg0 = new HomeMenuFunctions();

            return Result.Success;
        }

        [CmifCommand(21)]
        public Result GetGlobalStateController(out IGlobalStateController arg0)
        {
            arg0 = new GlobalStateController();

            return Result.Success;
        }

        [CmifCommand(22)]
        public Result GetApplicationCreator(out IApplicationCreator arg0)
        {
            arg0 = new ApplicationCreator();

            return Result.Success;
        }

        [CmifCommand(23)]
        public Result GetAppletCommonFunctions(out IAppletCommonFunctions arg0)
        {
            arg0 = new AppletCommonFunctions();

            return Result.Success;
        }
    }
}
