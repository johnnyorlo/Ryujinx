using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Capsrv.Sf
{
    class AlbumApplicationService : IAlbumApplicationService
    {
        [CmifCommand(32)]
        public Result SetShimLibraryVersion(ulong arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(102)]
        public Result GetAlbumFileList0AafeAruidDeprecated(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ApplicationAlbumFileEntry> arg1, byte arg2, long arg3, long arg4, AppletResourceUserId arg5, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(103)]
        public Result DeleteAlbumFileByAruid(ApplicationAlbumFileEntry arg0, byte arg1, AppletResourceUserId arg2, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(104)]
        public Result GetAlbumFileSizeByAruid(out ulong arg0, ApplicationAlbumFileEntry arg1, AppletResourceUserId arg2, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(105)]
        public Result DeleteAlbumFileByAruidForDebug(ApplicationAlbumFileEntry arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(110)]
        public Result LoadAlbumScreenShotImageByAruid([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x500)] out LoadAlbumScreenShotImageOutputForApplication arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] Span<byte> arg1, ApplicationAlbumFileEntry arg2, ScreenShotDecodeOption arg3, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg4, AppletResourceUserId arg5, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(120)]
        public Result LoadAlbumScreenShotThumbnailImageByAruid([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x500)] out LoadAlbumScreenShotImageOutputForApplication arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] Span<byte> arg1, ApplicationAlbumFileEntry arg2, ScreenShotDecodeOption arg3, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg4, AppletResourceUserId arg5, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(130)]
        public Result PrecheckToCreateContentsByAruid(byte arg0, ulong arg1, AppletResourceUserId arg2, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(140)]
        public Result GetAlbumFileList1AafeAruidDeprecated(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ApplicationAlbumFileEntry> arg1, byte arg2, AlbumFileDateTime arg3, AlbumFileDateTime arg4, AppletResourceUserId arg5, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(141)]
        public Result GetAlbumFileList2AafeUidAruidDeprecated(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ApplicationAlbumFileEntry> arg1, byte arg2, Uid arg3, AlbumFileDateTime arg4, AlbumFileDateTime arg5, AppletResourceUserId arg6, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(142)]
        public Result GetAlbumFileList3AaeAruid(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ApplicationAlbumEntry> arg1, byte arg2, AlbumFileDateTime arg3, AlbumFileDateTime arg4, AppletResourceUserId arg5, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(143)]
        public Result GetAlbumFileList4AaeUidAruid(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ApplicationAlbumEntry> arg1, byte arg2, Uid arg3, AlbumFileDateTime arg4, AlbumFileDateTime arg5, AppletResourceUserId arg6, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(144)]
        public Result GetAllAlbumFileList3AaeAruid(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ApplicationAlbumEntry> arg1, byte arg2, AlbumFileDateTime arg3, AlbumFileDateTime arg4, AppletResourceUserId arg5, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(60002)]
        public Result OpenAccessorSessionForApplication(out IAlbumAccessorApplicationSession arg0, ApplicationAlbumFileEntry arg1, AppletResourceUserId arg2, [ClientProcessId] ulong pid)
        {
            arg0 = new AlbumAccessorApplicationSession();

            return Result.Success;
        }
    }
}
