using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf.Cmif;

namespace Ryujinx.Horizon.Sdk.Sf.Hipc.Detail
{
    class HipcManager : IHipcManager
    {
        // Could not determine command ID, please fill it in manually
        public Result ConvertCurrentObjectToDomain(out CmifDomainObjectId arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result CopyFromCurrentDomain(out int arg0, CmifDomainObjectId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result CloneCurrentObject(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result QueryPointerBufferSize(out ushort arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        // Could not determine command ID, please fill it in manually
        public Result CloneCurrentObjectEx(out int arg0, uint arg1)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
