using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Settings
{
    interface ISettingsItemKeyIterator : IServiceObject
    {
        Result GoNext();
        Result GetKeySize(out ulong arg0);
        Result GetKey(out ulong arg0, Span<byte> arg1);
    }
}
