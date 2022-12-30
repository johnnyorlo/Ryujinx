using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Prepo.Detail.Ipc
{
    class PrepoService : IPrepoService
    {
        [CmifCommand(10100)]
        public Result SaveReportOld([Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1, ulong arg2)
        {
            return Result.Success;
        }

        [CmifCommand(10101)]
        public Result SaveReportWithUserOld(Uid arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2, ulong arg3)
        {
            return Result.Success;
        }

        [CmifCommand(10102)]
        public Result SaveReportOld2([Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1, ulong arg2)
        {
            return Result.Success;
        }

        [CmifCommand(10103)]
        public Result SaveReportWithUserOld2(Uid arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2, ulong arg3)
        {
            return Result.Success;
        }

        [CmifCommand(10104)]
        public Result SaveReport([Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg1, ulong arg2)
        {
            return Result.Success;
        }

        [CmifCommand(10105)]
        public Result SaveReportWithUser(Uid arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2, ulong arg3)
        {
            return Result.Success;
        }

        [CmifCommand(10200)]
        public Result RequestImmediateTransmission()
        {
            return Result.Success;
        }

        [CmifCommand(10300)]
        public Result GetTransmissionStatus(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10400)]
        public Result GetSystemSessionId(out ulong arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20100)]
        public Result SaveSystemReport([Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg0, ApplicationId arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg2)
        {
            return Result.Success;
        }

        [CmifCommand(20101)]
        public Result SaveSystemReportWithUser(Uid arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg1, ApplicationId arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg3)
        {
            return Result.Success;
        }

        [CmifCommand(20200)]
        public Result SetOperationMode(long arg0)
        {
            return Result.Success;
        }

        [CmifCommand(30100)]
        public Result ClearStorage()
        {
            return Result.Success;
        }

        [CmifCommand(30200)]
        public Result ClearStatistics()
        {
            return Result.Success;
        }

        [CmifCommand(30300)]
        public Result GetStorageUsage(out long arg0, out long arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(30400)]
        public Result GetStatistics([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x198)] out Statistics arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(30401)]
        public Result GetThroughputHistory(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ThroughputRecord> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(30500)]
        public Result GetLastUploadError()
        {
            return Result.Success;
        }

        [CmifCommand(30600)]
        public Result GetApplicationUploadSummary(out ulong arg0, out ulong arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(40100)]
        public Result IsUserAgreementCheckEnabled(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(40101)]
        public Result SetUserAgreementCheckEnabled(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(50100)]
        public Result ReadAllApplicationReportFiles(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(90100)]
        public Result ReadAllReportFiles(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
