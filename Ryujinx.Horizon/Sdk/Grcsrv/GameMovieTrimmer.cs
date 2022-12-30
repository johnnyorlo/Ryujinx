using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Grcsrv
{
    class GameMovieTrimmer : IGameMovieTrimmer
    {
        [CmifCommand(1)]
        public Result BeginTrim(GameMovieId arg0, int arg1, int arg2)
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result EndTrim(out GameMovieId arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result GetNotTrimmingEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20)]
        public Result SetThumbnailRgba([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] ReadOnlySpan<byte> arg0, int arg1, int arg2)
        {
            return Result.Success;
        }
    }
}
