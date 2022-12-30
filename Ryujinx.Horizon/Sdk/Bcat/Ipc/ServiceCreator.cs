using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Bcat.Ipc
{
    class ServiceCreator : IServiceCreator
    {
        [CmifCommand(0)]
        public Result CreateBcatService(out IBcatService arg0, ulong arg1, [ClientProcessId] ulong pid)
        {
            arg0 = new BcatService();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result CreateDeliveryCacheStorageService(out IDeliveryCacheStorageService arg0, ulong arg1, [ClientProcessId] ulong pid)
        {
            arg0 = new DeliveryCacheStorageService();

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result CreateDeliveryCacheStorageServiceWithApplicationId(out IDeliveryCacheStorageService arg0, ApplicationId arg1)
        {
            arg0 = new DeliveryCacheStorageService();

            return Result.Success;
        }
    }
}
