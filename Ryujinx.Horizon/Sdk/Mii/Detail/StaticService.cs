using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Mii.Detail
{
    class StaticService : IStaticService
    {
        [CmifCommand(0)]
        public Result GetDatabaseService(out IDatabaseService arg0, int arg1)
        {
            arg0 = new DatabaseService();

            return Result.Success;
        }
    }
}
