using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Util;
using System;

namespace Ryujinx.Horizon.Sdk.Nifm.Detail
{
    interface IRequest : IServiceObject
    {
        Result GetRequestState(out int arg0);
        Result GetResult();
        Result GetSystemEventReadableHandles(out int arg0, out int arg1);
        Result Cancel();
        Result Submit();
        Result SetRequirement(Requirement arg0);
        Result SetRequirementPreset(int arg0);
        Result SetPriority(byte arg0);
        Result SetNetworkProfileId(Uuid arg0);
        Result SetRejectable(bool arg0);
        Result SetConnectionConfirmationOption(sbyte arg0);
        Result SetPersistent(bool arg0);
        Result SetInstant(bool arg0);
        Result SetSustainable(bool arg0, byte arg1);
        Result SetRawPriority(byte arg0);
        Result SetGreedy(bool arg0);
        Result SetSharable(bool arg0);
        Result SetRequirementByRevision(uint arg0);
        Result GetRequirement(out Requirement arg0);
        Result GetRevision(out uint arg0);
        Result GetAppletInfo(out uint arg0, out uint arg1, out uint arg2, Span<byte> arg3, uint arg4);
        Result GetAdditionalInfo(out AdditionalInfo arg0, out uint arg1);
        Result SetKeptInSleep(bool arg0);
        Result RegisterSocketDescriptor(int arg0);
        Result UnregisterSocketDescriptor(int arg0);
    }
}
