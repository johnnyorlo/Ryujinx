using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Ngc.T.Detail
{
    class ServiceWithManagementApi : IServiceWithManagementApi
    {
        [CmifCommand(100)]
        public Result ConfigureAutoUpdateSetting()
        {
            return Result.Success;
        }

        [CmifCommand(101)]
        public Result RequestResourceUpdateCheck()
        {
            return Result.Success;
        }

        [CmifCommand(110)]
        public Result Reload()
        {
            return Result.Success;
        }

        [CmifCommand(111)]
        public Result IsReloadRequired(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(112)]
        public Result TryAcquireReloadRequestNotifier(out bool arg0, out INotifier arg1)
        {
            arg0 = default;
            arg1 = new Notifier();

            return Result.Success;
        }

        [CmifCommand(120)]
        public Result CalculateContentFingerprint([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(130)]
        public Result TryEnableTemporalPassThrough(out bool arg0, out IObject arg1)
        {
            arg0 = default;
            arg1 = new Object();

            return Result.Success;
        }
    }
}
