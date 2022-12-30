using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Capsrv.Detail;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Capsrv.Sf
{
    interface IScreenShotApplicationService : IServiceObject
    {
        Result SetShimLibraryVersion(ulong arg0, AppletResourceUserId arg1, ulong pid);
        Result SaveScreenShot(out ApplicationAlbumEntry arg0, ReadOnlySpan<byte> arg1, uint arg2, AppletResourceUserId arg3, uint arg4, ulong pid);
        Result SaveScreenShotEx0(out ApplicationAlbumEntry arg0, ReadOnlySpan<byte> arg1, ScreenShotAttributeEx0 arg2, AppletResourceUserId arg3, uint arg4, ulong pid);
        Result SaveScreenShotEx1(out ApplicationAlbumEntry arg0, ReadOnlySpan<byte> arg1, ScreenShotAttributeEx0 arg2, in ApplicationData arg3, AppletResourceUserId arg4, uint arg5, ulong pid);
        Result SaveScreenShotEx2(out ApplicationAlbumEntry arg0, ReadOnlySpan<byte> arg1, ScreenShotAttributeEx0 arg2, in UserIdList arg3, AppletResourceUserId arg4, uint arg5);
    }
}
