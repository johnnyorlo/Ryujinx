using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Hosbinder;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Vi;
using System;

namespace Ryujinx.Horizon.Sdk.Visrv.Sf
{
    interface IApplicationDisplayService : IServiceObject
    {
        Result GetRelayService(out IHOSBinderDriver arg0);
        Result GetSystemDisplayService(out ISystemDisplayService arg0);
        Result GetManagerDisplayService(out IManagerDisplayService arg0);
        Result GetIndirectDisplayTransactionService(out IHOSBinderDriver arg0);
        Result ListDisplays(out long arg0, Span<DisplayInfo> arg1);
        Result OpenDisplay(out ulong arg0, DisplayName arg1);
        Result OpenDefaultDisplay(out ulong arg0);
        Result CloseDisplay(ulong arg0);
        Result SetDisplayEnabled(ulong arg0, bool arg1);
        Result GetDisplayResolution(out long arg0, out long arg1, ulong arg2);
        Result OpenLayer(out long arg0, Span<byte> arg1, ulong arg2, DisplayName arg3, AppletResourceUserId arg4);
        Result CloseLayer(ulong arg0);
        Result CreateStrayLayer(out ulong arg0, out long arg1, Span<byte> arg2, ulong arg3, uint arg4);
        Result DestroyStrayLayer(ulong arg0);
        Result SetLayerScalingMode(ulong arg0, uint arg1);
        Result ConvertScalingMode(out long arg0, uint arg1);
        Result GetIndirectLayerImageMap(out long arg0, out long arg1, Span<byte> arg2, long arg3, long arg4, ulong arg5, AppletResourceUserId arg6);
        Result GetIndirectLayerImageCropMap(out long arg0, out long arg1, Span<byte> arg2, long arg3, long arg4, float arg5, float arg6, float arg7, float arg8, ulong arg9, AppletResourceUserId arg10);
        Result GetIndirectLayerImageRequiredMemoryInfo(out long arg0, out long arg1, long arg2, long arg3);
        Result GetDisplayVsyncEvent(out int arg0, ulong arg1);
        Result GetDisplayVsyncEventForDebug(out int arg0, ulong arg1);
    }
}
