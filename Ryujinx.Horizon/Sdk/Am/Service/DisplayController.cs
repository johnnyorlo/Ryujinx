using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class DisplayController : IDisplayController
    {
        [CmifCommand(0)]
        public Result GetLastForegroundCaptureImage([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(1)]
        public Result UpdateLastForegroundCaptureImage()
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetLastApplicationCaptureImage([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(3)]
        public Result GetCallerAppletCaptureImage([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result UpdateCallerAppletCaptureImage()
        {
            return Result.Success;
        }

        [CmifCommand(5)]
        public Result GetLastForegroundCaptureImageEx(out bool arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(6)]
        public Result GetLastApplicationCaptureImageEx(out bool arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(7)]
        public Result GetCallerAppletCaptureImageEx(out bool arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8)]
        public Result TakeScreenShotOfOwnLayer(int arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(9)]
        public Result CopyBetweenCaptureBuffers(int arg0, int arg1)
        {
            return Result.Success;
        }

        [CmifCommand(10)]
        public Result AcquireLastApplicationCaptureBuffer([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(11)]
        public Result ReleaseLastApplicationCaptureBuffer()
        {
            return Result.Success;
        }

        [CmifCommand(12)]
        public Result AcquireLastForegroundCaptureBuffer([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(13)]
        public Result ReleaseLastForegroundCaptureBuffer()
        {
            return Result.Success;
        }

        [CmifCommand(14)]
        public Result AcquireCallerAppletCaptureBuffer([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(15)]
        public Result ReleaseCallerAppletCaptureBuffer()
        {
            return Result.Success;
        }

        [CmifCommand(16)]
        public Result AcquireLastApplicationCaptureBufferEx(out bool arg0, [CopyHandle] out int arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(17)]
        public Result AcquireLastForegroundCaptureBufferEx(out bool arg0, [CopyHandle] out int arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(18)]
        public Result AcquireCallerAppletCaptureBufferEx(out bool arg0, [CopyHandle] out int arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(20)]
        public Result ClearCaptureBuffer(int arg0, bool arg1, uint arg2)
        {
            return Result.Success;
        }

        [CmifCommand(21)]
        public Result ClearAppletTransitionBuffer(uint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(22)]
        public Result AcquireLastApplicationCaptureSharedBuffer(out bool arg0, out int arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(23)]
        public Result ReleaseLastApplicationCaptureSharedBuffer()
        {
            return Result.Success;
        }

        [CmifCommand(24)]
        public Result AcquireLastForegroundCaptureSharedBuffer(out bool arg0, out int arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(25)]
        public Result ReleaseLastForegroundCaptureSharedBuffer()
        {
            return Result.Success;
        }

        [CmifCommand(26)]
        public Result AcquireCallerAppletCaptureSharedBuffer(out bool arg0, out int arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(27)]
        public Result ReleaseCallerAppletCaptureSharedBuffer()
        {
            return Result.Success;
        }

        [CmifCommand(28)]
        public Result TakeScreenShotOfOwnLayerEx(int arg0, bool arg1, bool arg2)
        {
            return Result.Success;
        }
    }
}
