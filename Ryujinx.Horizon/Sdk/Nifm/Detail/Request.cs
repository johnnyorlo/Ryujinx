using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using Ryujinx.Horizon.Sdk.Util;
using System;

namespace Ryujinx.Horizon.Sdk.Nifm.Detail
{
    class Request : IRequest
    {
        [CmifCommand(0)]
        public Result GetRequestState(out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetResult()
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetSystemEventReadableHandles([CopyHandle] out int arg0, [CopyHandle] out int arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result Cancel()
        {
            return Result.Success;
        }

        [CmifCommand(4)]
        public Result Submit()
        {
            return Result.Success;
        }

        [CmifCommand(5)]
        public Result SetRequirement(Requirement arg0)
        {
            return Result.Success;
        }

        [CmifCommand(6)]
        public Result SetRequirementPreset(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(8)]
        public Result SetPriority(byte arg0)
        {
            return Result.Success;
        }

        [CmifCommand(9)]
        public Result SetNetworkProfileId(Uuid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(10)]
        public Result SetRejectable(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result SetConnectionConfirmationOption(sbyte arg0)
        {
            return Result.Success;
        }

        [CmifCommand(12)]
        public Result SetPersistent(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(13)]
        public Result SetInstant(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(14)]
        public Result SetSustainable(bool arg0, byte arg1)
        {
            return Result.Success;
        }

        [CmifCommand(15)]
        public Result SetRawPriority(byte arg0)
        {
            return Result.Success;
        }

        [CmifCommand(16)]
        public Result SetGreedy(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(17)]
        public Result SetSharable(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(18)]
        public Result SetRequirementByRevision(uint arg0)
        {
            return Result.Success;
        }

        [CmifCommand(19)]
        public Result GetRequirement(out Requirement arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20)]
        public Result GetRevision(out uint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(21)]
        public Result GetAppletInfo(out uint arg0, out uint arg1, out uint arg2, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg3, uint arg4)
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;

            return Result.Success;
        }

        [CmifCommand(22)]
        public Result GetAdditionalInfo([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x410)] out AdditionalInfo arg0, out uint arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(23)]
        public Result SetKeptInSleep(bool arg0)
        {
            return Result.Success;
        }

        [CmifCommand(24)]
        public Result RegisterSocketDescriptor(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(25)]
        public Result UnregisterSocketDescriptor(int arg0)
        {
            return Result.Success;
        }
    }
}
