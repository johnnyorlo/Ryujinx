using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Grcsrv
{
    interface IGameMovieTrimmer : IServiceObject
    {
        Result BeginTrim(GameMovieId arg0, int arg1, int arg2);
        Result EndTrim(out GameMovieId arg0);
        Result GetNotTrimmingEvent(out int arg0);
        Result SetThumbnailRgba(ReadOnlySpan<byte> arg0, int arg1, int arg2);
    }
}
