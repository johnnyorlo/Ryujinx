using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Hid
{
    interface IActiveVibrationDeviceList : IServiceObject
    {
        Result ActivateVibrationDevice(VibrationDeviceHandle arg0);
    }
}
