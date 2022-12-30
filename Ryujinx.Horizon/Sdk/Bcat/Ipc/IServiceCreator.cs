using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Bcat.Ipc
{
    interface IServiceCreator : IServiceObject
    {
        Result CreateBcatService(out IBcatService arg0, ulong arg1);
        Result CreateDeliveryCacheStorageService(out IDeliveryCacheStorageService arg0, ulong arg1);
        Result CreateDeliveryCacheStorageServiceWithApplicationId(out IDeliveryCacheStorageService arg0, ApplicationId arg1);
    }
}
