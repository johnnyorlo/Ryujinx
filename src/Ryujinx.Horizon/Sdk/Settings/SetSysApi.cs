using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf.Cmif;
using Ryujinx.Horizon.Sdk.Sm;
using System;
using System.Runtime.InteropServices;

namespace Ryujinx.Horizon.Sdk.Settings
{
    public class SetSysApi
    {
        private const string SetSysName = "set:sys";

        private int _sessionHandle;

        public SetSysApi(SmApi smApi)
        {
            smApi.GetServiceHandle(out _sessionHandle, ServiceName.Encode(SetSysName)).AbortOnFailure();
        }

        public Result GetMiiAuthorId(out UInt128 uuid)
        {
            Result result = ServiceUtil.SendRequest(out CmifResponse response, _sessionHandle, 90, sendPid: false, ReadOnlySpan<byte>.Empty);

            if (result.IsFailure)
            {
                uuid = default;

                return result;
            }

            uuid = MemoryMarshal.Cast<byte, UInt128>(response.Data)[0];

            return Result.Success;
        }
    }
}