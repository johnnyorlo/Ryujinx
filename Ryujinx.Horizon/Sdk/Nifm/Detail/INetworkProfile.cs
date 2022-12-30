using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Nifm.Detail.Sf;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Util;

namespace Ryujinx.Horizon.Sdk.Nifm.Detail
{
    interface INetworkProfile : IServiceObject
    {
        Result Update(out Uuid arg0, in NetworkProfileData arg1);
        Result PersistOld(out Uuid arg0, Uuid arg1);
        Result Persist(out Uuid arg0);
    }
}
