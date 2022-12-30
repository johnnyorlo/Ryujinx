using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Bcat.Ipc
{
    interface IDeliveryCacheProgressService : IServiceObject
    {
        Result GetEvent(out int arg0);
        Result GetImpl(out DeliveryCacheProgressImpl arg0);
    }
}
