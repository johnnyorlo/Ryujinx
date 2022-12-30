using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Ngc.T.Detail
{
    interface IServiceWithManagementApi : IServiceObject
    {
        Result ConfigureAutoUpdateSetting();
        Result RequestResourceUpdateCheck();
        Result Reload();
        Result IsReloadRequired(out bool arg0);
        Result TryAcquireReloadRequestNotifier(out bool arg0, out INotifier arg1);
        Result CalculateContentFingerprint(Span<byte> arg0);
        Result TryEnableTemporalPassThrough(out bool arg0, out IObject arg1);
    }
}
