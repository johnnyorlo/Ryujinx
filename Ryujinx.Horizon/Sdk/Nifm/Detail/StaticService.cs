using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Nifm.Detail
{
    class StaticService : IStaticService
    {
        [CmifCommand(4)]
        public Result CreateGeneralServiceOld(out IGeneralService arg0)
        {
            arg0 = new GeneralService();

            return Result.Success;
        }

        [CmifCommand(5)]
        public Result CreateGeneralService(out IGeneralService arg0, ulong arg1, [ClientProcessId] ulong pid)
        {
            arg0 = new GeneralService();

            return Result.Success;
        }
    }
}
