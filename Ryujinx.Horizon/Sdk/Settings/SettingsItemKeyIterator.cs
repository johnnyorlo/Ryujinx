using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Settings
{
    class SettingsItemKeyIterator : ISettingsItemKeyIterator
    {
        [CmifCommand(0)]
        public Result GoNext()
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetKeySize(out ulong arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetKey(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
