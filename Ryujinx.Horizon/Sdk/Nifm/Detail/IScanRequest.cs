using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Nifm.Detail
{
    interface IScanRequest : IServiceObject
    {
        Result Submit();
        Result IsProcessing(out bool arg0);
        Result GetResult();
        Result GetSystemEventReadableHandle(out int arg0);
        Result SetChannels(ReadOnlySpan<short> arg0);
    }
}
