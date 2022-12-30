using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Dp2hdmi.Detail
{
    interface IDp2hdmiController : IServiceObject
    {
        Result GetFirmwareVersion(out FirmwareVersion arg0);
        Result GetAvailableFirmwareVersion(out FirmwareVersion arg0);
        Result CheckFirmwareUpdateRequired(out int arg0);
        Result StartFirmwareUpdate();
        Result StartFirmwareUpdateWithSpecifiedImage(int arg0, uint arg1);
        Result GetFirmwareUpdateState(out FirmwareUpdateState arg0);
        Result ResetDevice();
    }
}
