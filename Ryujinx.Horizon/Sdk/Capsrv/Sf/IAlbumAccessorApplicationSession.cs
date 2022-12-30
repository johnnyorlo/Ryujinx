using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Capsrv.Sf
{
    interface IAlbumAccessorApplicationSession : IServiceObject
    {
        Result OpenAlbumMovieReadStream(out ulong arg0, ApplicationAlbumFileEntry arg1, AppletResourceUserId arg2);
        Result CloseAlbumMovieReadStream(ulong arg0);
        Result GetAlbumMovieReadStreamMovieDataSize(out long arg0, ulong arg1);
        Result ReadMovieDataFromAlbumMovieReadStream(out long arg0, Span<byte> arg1, ulong arg2, long arg3);
        Result GetAlbumMovieReadStreamBrokenReason(ulong arg0);
    }
}
