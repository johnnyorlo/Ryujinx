using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Capsrv.Sf
{
    class AlbumAccessorApplicationSession : IAlbumAccessorApplicationSession
    {
        [CmifCommand(2001)]
        public Result OpenAlbumMovieReadStream(out ulong arg0, ApplicationAlbumFileEntry arg1, AppletResourceUserId arg2, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2002)]
        public Result CloseAlbumMovieReadStream(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2003)]
        public Result GetAlbumMovieReadStreamMovieDataSize(out long arg0, ulong arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2004)]
        public Result ReadMovieDataFromAlbumMovieReadStream(out long arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1, ulong arg2, long arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2005)]
        public Result GetAlbumMovieReadStreamBrokenReason(ulong arg0)
        {
            return Result.Success;
        }
    }
}
