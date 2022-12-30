using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Olsc.Srv
{
    interface IOlscServiceForApplication : IServiceObject
    {
        Result Initialize(ulong arg0, ulong pid);
        Result VerifySaveDataBackupLicenseAsync(out IAsyncResult arg0, Uid arg1);
        Result GetSaveDataBackupSetting(out SaveDataBackupSetting arg0, Uid arg1);
        Result SetSaveDataBackupSettingEnabled(Uid arg0, bool arg1);
        Result SetCustomData(Uid arg0, ReadOnlySpan<byte> arg1);
        Result DeleteSaveDataBackupSetting(Uid arg0);
        Result GetSaveDataBackupInfoCache(out SaveDataBackupInfo arg0, Uid arg1);
        Result UpdateSaveDataBackupInfoCacheAsync(out IAsyncResult arg0, Uid arg1);
        Result DeleteSaveDataBackupAsync(out IAsyncResult arg0, Uid arg1, SaveDataBackupId arg2);
        Result ListDownloadableSaveDataBackupInfoAsync(out IAsyncListData arg0, Uid arg1, int arg2, uint arg3);
        Result DownloadSaveDataBackupAsync(out IAsyncTransferRequest arg0, Uid arg1, SaveDataBackupId arg2);
        Result UploadSaveDataBackupAsync(out IAsyncTransferRequest arg0, Uid arg1);
    }
}
