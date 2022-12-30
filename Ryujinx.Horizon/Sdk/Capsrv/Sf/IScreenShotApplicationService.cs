using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Capsrv.Detail;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Capsrv.Sf
{
    interface IScreenShotApplicationService : IServiceObject
    {
        Result SetShimLibraryVersion(ulong arg0, AppletResourceUserId arg1);
        Result SaveScreenShot(out ApplicationAlbumEntry arg0, ReadOnlySpan<byte> arg1, uint arg2, AppletResourceUserId arg3, uint arg4);
        Result SaveScreenShotEx0(out ApplicationAlbumEntry arg0, ReadOnlySpan<byte> arg1, ScreenShotAttributeEx0 arg2, AppletResourceUserId arg3, uint arg4);
        Result SaveScreenShotEx1(out ApplicationAlbumEntry arg0, ReadOnlySpan<byte> arg1, ScreenShotAttributeEx0 arg2, ApplicationData arg3, AppletResourceUserId arg4, uint arg5);
        Result SaveScreenShotEx2(out ApplicationAlbumEntry arg0, ReadOnlySpan<byte> arg1, ScreenShotAttributeEx0 arg2, UserIdList arg3, AppletResourceUserId arg4, uint arg5);
    }
}
