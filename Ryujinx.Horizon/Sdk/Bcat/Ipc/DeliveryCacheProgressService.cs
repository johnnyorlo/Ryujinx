using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;

namespace Ryujinx.Horizon.Sdk.Bcat.Ipc
{
    class DeliveryCacheProgressService : IDeliveryCacheProgressService
    {
        [CmifCommand(0)]
        public Result GetEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetImpl([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x200)] out DeliveryCacheProgressImpl arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
