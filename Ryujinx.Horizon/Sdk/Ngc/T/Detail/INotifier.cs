using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Ngc.T.Detail
{
    interface INotifier : IServiceObject
    {
        Result GetSystemEvent(out int arg0);
    }
}
