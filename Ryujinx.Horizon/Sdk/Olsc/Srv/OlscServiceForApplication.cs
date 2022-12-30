using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Olsc.Srv
{
    class OlscServiceForApplication : IOlscServiceForApplication
    {
        [CmifCommand(0)]
        public Result Initialize(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(10)]
        public Result VerifySaveDataBackupLicenseAsync(out IAsyncResult arg0, Uid arg1)
        {
            arg0 = new AsyncResult();

            return Result.Success;
        }

        [CmifCommand(13)]
        public Result GetSaveDataBackupSetting(out SaveDataBackupSetting arg0, Uid arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(14)]
        public Result SetSaveDataBackupSettingEnabled(Uid arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(15)]
        public Result SetCustomData(Uid arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(16)]
        public Result DeleteSaveDataBackupSetting(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(18)]
        public Result GetSaveDataBackupInfoCache([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x410)] out SaveDataBackupInfo arg0, Uid arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(19)]
        public Result UpdateSaveDataBackupInfoCacheAsync(out IAsyncResult arg0, Uid arg1)
        {
            arg0 = new AsyncResult();

            return Result.Success;
        }

        [CmifCommand(22)]
        public Result DeleteSaveDataBackupAsync(out IAsyncResult arg0, Uid arg1, SaveDataBackupId arg2)
        {
            arg0 = new AsyncResult();

            return Result.Success;
        }

        [CmifCommand(25)]
        public Result ListDownloadableSaveDataBackupInfoAsync(out IAsyncListData arg0, Uid arg1, [CopyHandle] int arg2, uint arg3)
        {
            arg0 = new AsyncListData();

            return Result.Success;
        }

        [CmifCommand(26)]
        public Result DownloadSaveDataBackupAsync(out IAsyncTransferRequest arg0, Uid arg1, SaveDataBackupId arg2)
        {
            arg0 = new AsyncTransferRequest();

            return Result.Success;
        }

        [CmifCommand(27)]
        public Result UploadSaveDataBackupAsync(out IAsyncTransferRequest arg0, Uid arg1)
        {
            arg0 = new AsyncTransferRequest();

            return Result.Success;
        }
    }
}
