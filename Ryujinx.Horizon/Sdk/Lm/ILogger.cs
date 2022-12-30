using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Lm
{
    interface ILogger : IServiceObject
    {
        Result Log(ReadOnlySpan<byte> arg0);
        Result SetDestination(uint arg0);
    }
}
