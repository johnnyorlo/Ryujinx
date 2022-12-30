using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Olsc.Srv
{
    class AsyncTransferRequest : IAsyncTransferRequest
    {
        [CmifCommand(100)]
        public Result GetOperationProgressInfo(out OperationProgressInfoRaw arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
