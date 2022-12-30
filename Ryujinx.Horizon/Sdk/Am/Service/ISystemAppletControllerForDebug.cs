using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface ISystemAppletControllerForDebug : IServiceObject
    {
        Result RequestLaunchApplicationForDebug(ApplicationId arg0, ReadOnlySpan<Uid> arg1);
        Result GetDebugStorageChannel(out IStorageChannel arg0);
        Result CreateStorageForDebug(out IStorage arg0, long arg1);
        Result CreateCradleFirmwareUpdaterForDebug(out ICradleFirmwareUpdater arg0);
    }
}
