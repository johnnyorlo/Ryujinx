using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Capsrv.Sf
{
    interface IAlbumApplicationService : IServiceObject
    {
        Result SetShimLibraryVersion(ulong arg0, AppletResourceUserId arg1, ulong pid);
        Result GetAlbumFileList0AafeAruidDeprecated(out ulong arg0, Span<ApplicationAlbumFileEntry> arg1, byte arg2, long arg3, long arg4, AppletResourceUserId arg5, ulong pid);
        Result DeleteAlbumFileByAruid(ApplicationAlbumFileEntry arg0, byte arg1, AppletResourceUserId arg2, ulong pid);
        Result GetAlbumFileSizeByAruid(out ulong arg0, ApplicationAlbumFileEntry arg1, AppletResourceUserId arg2, ulong pid);
        Result DeleteAlbumFileByAruidForDebug(ApplicationAlbumFileEntry arg0, AppletResourceUserId arg1, ulong pid);
        Result LoadAlbumScreenShotImageByAruid(out LoadAlbumScreenShotImageOutputForApplication arg0, Span<byte> arg1, ApplicationAlbumFileEntry arg2, ScreenShotDecodeOption arg3, Span<byte> arg4, AppletResourceUserId arg5, ulong pid);
        Result LoadAlbumScreenShotThumbnailImageByAruid(out LoadAlbumScreenShotImageOutputForApplication arg0, Span<byte> arg1, ApplicationAlbumFileEntry arg2, ScreenShotDecodeOption arg3, Span<byte> arg4, AppletResourceUserId arg5, ulong pid);
        Result PrecheckToCreateContentsByAruid(byte arg0, ulong arg1, AppletResourceUserId arg2, ulong pid);
        Result GetAlbumFileList1AafeAruidDeprecated(out ulong arg0, Span<ApplicationAlbumFileEntry> arg1, byte arg2, AlbumFileDateTime arg3, AlbumFileDateTime arg4, AppletResourceUserId arg5, ulong pid);
        Result GetAlbumFileList2AafeUidAruidDeprecated(out ulong arg0, Span<ApplicationAlbumFileEntry> arg1, byte arg2, Uid arg3, AlbumFileDateTime arg4, AlbumFileDateTime arg5, AppletResourceUserId arg6, ulong pid);
        Result GetAlbumFileList3AaeAruid(out ulong arg0, Span<ApplicationAlbumEntry> arg1, byte arg2, AlbumFileDateTime arg3, AlbumFileDateTime arg4, AppletResourceUserId arg5, ulong pid);
        Result GetAlbumFileList4AaeUidAruid(out ulong arg0, Span<ApplicationAlbumEntry> arg1, byte arg2, Uid arg3, AlbumFileDateTime arg4, AlbumFileDateTime arg5, AppletResourceUserId arg6, ulong pid);
        Result GetAllAlbumFileList3AaeAruid(out ulong arg0, Span<ApplicationAlbumEntry> arg1, byte arg2, AlbumFileDateTime arg3, AlbumFileDateTime arg4, AppletResourceUserId arg5, ulong pid);
        Result OpenAccessorSessionForApplication(out IAlbumAccessorApplicationSession arg0, ApplicationAlbumFileEntry arg1, AppletResourceUserId arg2, ulong pid);
    }
}
