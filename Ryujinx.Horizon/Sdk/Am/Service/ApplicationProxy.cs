using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class ApplicationProxy : IApplicationProxy
    {
        [CmifCommand(20)]
        public Result GetApplicationFunctions(out IApplicationFunctions arg0)
        {
            arg0 = new ApplicationFunctions();

            return Result.Success;
        }
    }
}
