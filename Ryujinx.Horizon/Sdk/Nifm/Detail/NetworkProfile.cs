using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Nifm.Detail.Sf;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using Ryujinx.Horizon.Sdk.Util;

namespace Ryujinx.Horizon.Sdk.Nifm.Detail
{
    class NetworkProfile : INetworkProfile
    {
        [CmifCommand(0)]
        public Result Update(out Uuid arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x17C)] NetworkProfileData arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result PersistOld(out Uuid arg0, Uuid arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result Persist(out Uuid arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
