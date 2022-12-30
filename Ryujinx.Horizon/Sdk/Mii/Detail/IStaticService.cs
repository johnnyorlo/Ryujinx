using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Mii.Detail
{
    interface IStaticService : IServiceObject
    {
        Result GetDatabaseService(out IDatabaseService arg0, int arg1);
    }
}
