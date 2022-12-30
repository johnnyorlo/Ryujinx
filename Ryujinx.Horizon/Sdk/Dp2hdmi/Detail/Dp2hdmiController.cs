using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Dp2hdmi.Detail
{
    class Dp2hdmiController : IDp2hdmiController
    {
        [CmifCommand(0)]
        public Result GetFirmwareVersion(out FirmwareVersion arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetAvailableFirmwareVersion(out FirmwareVersion arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result CheckFirmwareUpdateRequired(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result StartFirmwareUpdate()
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result StartFirmwareUpdateWithSpecifiedImage([CopyHandle] int arg0, uint arg1)
        {
            return Result.Success;
        }

        [CmifCommand(5)]
        public Result GetFirmwareUpdateState(out FirmwareUpdateState arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(6)]
        public Result ResetDevice()
        {
            return Result.Success;
        }
    }
}
