using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class GlobalStateController : IGlobalStateController
    {
        [CmifCommand(0)]
        public Result RequestToEnterSleep()
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result EnterSleep()
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result StartSleepSequence(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(3)]
        public Result StartShutdownSequence()
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result StartRebootSequence()
        {
            return Result.Success;
        }

        [CmifCommand(9)]
        public Result IsAutoPowerDownRequested(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result LoadAndApplyIdlePolicySettings()
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result NotifyCecSettingsChanged()
        {
            return Result.Success;
        }

        [CmifCommand(12)]
        public Result SetDefaultHomeButtonLongPressTime(long arg0)
        {
            return Result.Success;
        }

        [CmifCommand(13)]
        public Result UpdateDefaultDisplayResolution()
        {
            return Result.Success;
        }

        [CmifCommand(14)]
        public Result ShouldSleepOnBoot(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(15)]
        public Result GetHdcpAuthenticationFailedEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(30)]
        public Result OpenCradleFirmwareUpdater(out ICradleFirmwareUpdater arg0)
        {
            arg0 = new CradleFirmwareUpdater();

            return Result.Success;
        }
    }
}
