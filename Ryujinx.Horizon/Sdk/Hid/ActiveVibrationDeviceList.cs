using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Hid
{
    class ActiveVibrationDeviceList : IActiveVibrationDeviceList
    {
        [CmifCommand(0)]
        public Result ActivateVibrationDevice(VibrationDeviceHandle arg0)
        {
            return Result.Success;
        }
    }
}
