using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IApplicationProxy : IServiceObject
    {
        Result GetApplicationFunctions(out IApplicationFunctions arg0);
    }
}
