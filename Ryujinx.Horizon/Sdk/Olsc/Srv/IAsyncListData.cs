using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Olsc.Srv
{
    interface IAsyncListData : IServiceObject
    {
        Result GetDataCount(out int arg0);
        Result GetData(out int arg0, Span<SaveDataBackupInfo> arg1, int arg2);
    }
}
