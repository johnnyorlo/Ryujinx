using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Jitsrv
{
    class JitService : IJitService
    {
        [CmifCommand(0)]
        public Result CreateJitEnvironment(out IJitEnvironment arg0, [CopyHandle] int arg1, [CopyHandle] int arg2, ulong arg3, [CopyHandle] int arg4, ulong arg5)
        {
            arg0 = new JitEnvironment();

            return Result.Success;
        }
    }
}
