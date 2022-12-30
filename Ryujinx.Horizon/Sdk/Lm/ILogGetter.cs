using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Lm
{
    interface ILogGetter : IServiceObject
    {
        Result StartLogging();
        Result StopLogging();
        Result GetLog(Span<byte> arg0, out long arg1, out uint arg2);
    }
}
