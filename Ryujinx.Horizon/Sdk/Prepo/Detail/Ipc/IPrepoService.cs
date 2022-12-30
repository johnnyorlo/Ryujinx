using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Prepo.Detail.Ipc
{
    interface IPrepoService : IServiceObject
    {
        Result SaveReportOld(ReadOnlySpan<sbyte> arg0, ReadOnlySpan<byte> arg1, ulong arg2, ulong pid);
        Result SaveReportWithUserOld(Uid arg0, ReadOnlySpan<sbyte> arg1, ReadOnlySpan<byte> arg2, ulong arg3, ulong pid);
        Result SaveReportOld2(ReadOnlySpan<sbyte> arg0, ReadOnlySpan<byte> arg1, ulong arg2, ulong pid);
        Result SaveReportWithUserOld2(Uid arg0, ReadOnlySpan<sbyte> arg1, ReadOnlySpan<byte> arg2, ulong arg3, ulong pid);
        Result SaveReport(ReadOnlySpan<sbyte> arg0, ReadOnlySpan<byte> arg1, ulong arg2, ulong pid);
        Result SaveReportWithUser(Uid arg0, ReadOnlySpan<sbyte> arg1, ReadOnlySpan<byte> arg2, ulong arg3, ulong pid);
        Result RequestImmediateTransmission();
        Result GetTransmissionStatus(out int arg0);
        Result GetSystemSessionId(out ulong arg0);
        Result SaveSystemReport(ReadOnlySpan<sbyte> arg0, ApplicationId arg1, ReadOnlySpan<byte> arg2);
        Result SaveSystemReportWithUser(Uid arg0, ReadOnlySpan<sbyte> arg1, ApplicationId arg2, ReadOnlySpan<byte> arg3);
        Result SetOperationMode(long arg0);
        Result ClearStorage();
        Result ClearStatistics();
        Result GetStorageUsage(out long arg0, out long arg1);
        Result GetStatistics(out Statistics arg0);
        Result GetThroughputHistory(out int arg0, Span<ThroughputRecord> arg1);
        Result GetLastUploadError();
        Result GetApplicationUploadSummary(out ulong arg0, out ulong arg1);
        Result IsUserAgreementCheckEnabled(out bool arg0);
        Result SetUserAgreementCheckEnabled(bool arg0);
        Result ReadAllApplicationReportFiles(out ulong arg0, Span<byte> arg1);
        Result ReadAllReportFiles(out ulong arg0, Span<byte> arg1);
    }
}
