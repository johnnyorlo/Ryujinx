using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Bcat.Ipc
{
    class DeliveryTaskSuspensionService : IDeliveryTaskSuspensionService
    {
        [CmifCommand(0)]
        public Result GetEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
