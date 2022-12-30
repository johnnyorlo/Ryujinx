using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Lm
{
    interface ILogService : IServiceObject
    {
        Result OpenLogger(out ILogger arg0, ulong arg1, ulong pid);
    }
}
