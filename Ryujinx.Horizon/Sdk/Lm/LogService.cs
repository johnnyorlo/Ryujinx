using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Lm
{
    class LogService : ILogService
    {
        [CmifCommand(0)]
        public Result OpenLogger(out ILogger arg0, ulong arg1, [ClientProcessId] ulong pid)
        {
            arg0 = new Logger();

            return Result.Success;
        }
    }
}
