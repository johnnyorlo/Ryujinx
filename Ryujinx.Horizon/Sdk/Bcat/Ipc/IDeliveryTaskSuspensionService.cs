using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Bcat.Ipc
{
    interface IDeliveryTaskSuspensionService : IServiceObject
    {
        Result GetEvent(out int arg0);
    }
}
