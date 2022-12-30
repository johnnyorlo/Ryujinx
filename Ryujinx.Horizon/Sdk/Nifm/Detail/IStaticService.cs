using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Nifm.Detail
{
    interface IStaticService : IServiceObject
    {
        Result CreateGeneralServiceOld(out IGeneralService arg0);
        Result CreateGeneralService(out IGeneralService arg0, ulong arg1);
    }
}
