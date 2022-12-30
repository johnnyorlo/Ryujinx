using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class ApplicationProxyService : IApplicationProxyService
    {
        [CmifCommand(0)]
        public Result OpenApplicationProxy(out IApplicationProxy arg0, ulong arg1, [CopyHandle] int arg2, [ClientProcessId] ulong pid)
        {
            arg0 = new ApplicationProxy();

            return Result.Success;
        }
    }
}
