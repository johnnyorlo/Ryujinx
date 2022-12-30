using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Capsrv.Detail;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Capsrv.Sf
{
    class ScreenShotApplicationService : IScreenShotApplicationService
    {
        [CmifCommand(32)]
        public Result SetShimLibraryVersion(ulong arg0, AppletResourceUserId arg1, [ClientProcessId] ulong pid)
        {
            return Result.Success;
        }

        [CmifCommand(201)]
        public Result SaveScreenShot(out ApplicationAlbumEntry arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] ReadOnlySpan<byte> arg1, uint arg2, AppletResourceUserId arg3, uint arg4, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(203)]
        public Result SaveScreenShotEx0(out ApplicationAlbumEntry arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] ReadOnlySpan<byte> arg1, ScreenShotAttributeEx0 arg2, AppletResourceUserId arg3, uint arg4, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(205)]
        public Result SaveScreenShotEx1(out ApplicationAlbumEntry arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] ReadOnlySpan<byte> arg1, ScreenShotAttributeEx0 arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x404)] in ApplicationData arg3, AppletResourceUserId arg4, uint arg5, [ClientProcessId] ulong pid)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(210)]
        public Result SaveScreenShotEx2(out ApplicationAlbumEntry arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias | HipcBufferFlags.MapTransferAllowsNonSecure)] ReadOnlySpan<byte> arg1, ScreenShotAttributeEx0 arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x88)] in UserIdList arg3, AppletResourceUserId arg4, uint arg5)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
