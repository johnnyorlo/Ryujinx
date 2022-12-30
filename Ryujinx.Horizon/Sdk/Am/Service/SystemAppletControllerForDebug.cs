using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class SystemAppletControllerForDebug : ISystemAppletControllerForDebug
    {
        [CmifCommand(1)]
        public Result RequestLaunchApplicationForDebug(ApplicationId arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<Uid> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetDebugStorageChannel(out IStorageChannel arg0)
        {
            arg0 = new StorageChannel();

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result CreateStorageForDebug(out IStorage arg0, long arg1)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result CreateCradleFirmwareUpdaterForDebug(out ICradleFirmwareUpdater arg0)
        {
            arg0 = new CradleFirmwareUpdater();

            return Result.Success;
        }
    }
}
