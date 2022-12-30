using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Bcat.Ipc
{
    interface INotifierService : IServiceObject
    {
        Result GetEvent(out int arg0);
    }
}
