using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class CradleFirmwareUpdater : ICradleFirmwareUpdater
    {
        [CmifCommand(0)]
        public Result StartUpdate()
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result FinishUpdate()
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetCradleDeviceInfo(out CradleDeviceInfo arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetCradleDeviceInfoChangeEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result GetUpdateProgressInfo(out UpdateProgressInfo arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(5)]
        public Result GetLastInternalResult()
        {
            return Result.Success;
        }
    }
}
