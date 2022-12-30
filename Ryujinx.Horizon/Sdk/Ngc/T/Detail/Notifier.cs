using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Ngc.T.Detail
{
    class Notifier : INotifier
    {
        [CmifCommand(0)]
        public Result GetSystemEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
