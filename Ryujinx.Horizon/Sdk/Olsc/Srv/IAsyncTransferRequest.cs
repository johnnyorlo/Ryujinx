using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Olsc.Srv
{
    interface IAsyncTransferRequest : IServiceObject
    {
        Result GetOperationProgressInfo(out OperationProgressInfoRaw arg0);
    }
}
