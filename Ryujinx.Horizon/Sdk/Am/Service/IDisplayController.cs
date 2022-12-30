using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IDisplayController : IServiceObject
    {
        Result GetLastForegroundCaptureImage(Span<byte> arg0);
        Result UpdateLastForegroundCaptureImage();
        Result GetLastApplicationCaptureImage(Span<byte> arg0);
        Result GetCallerAppletCaptureImage(Span<byte> arg0);
        Result UpdateCallerAppletCaptureImage();
        Result GetLastForegroundCaptureImageEx(out bool arg0, Span<byte> arg1);
        Result GetLastApplicationCaptureImageEx(out bool arg0, Span<byte> arg1);
        Result GetCallerAppletCaptureImageEx(out bool arg0, Span<byte> arg1);
        Result TakeScreenShotOfOwnLayer(int arg0, bool arg1);
        Result CopyBetweenCaptureBuffers(int arg0, int arg1);
        Result AcquireLastApplicationCaptureBuffer(out int arg0);
        Result ReleaseLastApplicationCaptureBuffer();
        Result AcquireLastForegroundCaptureBuffer(out int arg0);
        Result ReleaseLastForegroundCaptureBuffer();
        Result AcquireCallerAppletCaptureBuffer(out int arg0);
        Result ReleaseCallerAppletCaptureBuffer();
        Result AcquireLastApplicationCaptureBufferEx(out bool arg0, out int arg1);
        Result AcquireLastForegroundCaptureBufferEx(out bool arg0, out int arg1);
        Result AcquireCallerAppletCaptureBufferEx(out bool arg0, out int arg1);
        Result ClearCaptureBuffer(int arg0, bool arg1, uint arg2);
        Result ClearAppletTransitionBuffer(uint arg0);
        Result AcquireLastApplicationCaptureSharedBuffer(out bool arg0, out int arg1);
        Result ReleaseLastApplicationCaptureSharedBuffer();
        Result AcquireLastForegroundCaptureSharedBuffer(out bool arg0, out int arg1);
        Result ReleaseLastForegroundCaptureSharedBuffer();
        Result AcquireCallerAppletCaptureSharedBuffer(out bool arg0, out int arg1);
        Result ReleaseCallerAppletCaptureSharedBuffer();
        Result TakeScreenShotOfOwnLayerEx(int arg0, bool arg1, bool arg2);
    }
}
