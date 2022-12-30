using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Applet;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class ApplicationAccessor : IApplicationAccessor
    {
        [CmifCommand(101)]
        public Result RequestForApplicationToGetForeground()
        {
            return Result.Success;
        }

        [CmifCommand(110)]
        public Result TerminateAllLibraryApplets()
        {
            return Result.Success;
        }

        [CmifCommand(111)]
        public Result AreAnyLibraryAppletsLeft(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(112)]
        public Result GetCurrentLibraryApplet(out IAppletAccessor arg0)
        {
            arg0 = new AppletAccessor();

            return Result.Success;
        }

        [CmifCommand(120)]
        public Result GetApplicationId(out ApplicationId arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(121)]
        public Result PushLaunchParameter(uint arg0, IStorage arg1)
        {
            return Result.Success;
        }

        [CmifCommand(122)]
        public Result GetApplicationControlProperty([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(123)]
        public Result GetApplicationLaunchProperty([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(124)]
        public Result GetApplicationLaunchRequestInfo(out ApplicationLaunchRequestInfo arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(130)]
        public Result SetUsers(bool arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<Uid> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(131)]
        public Result CheckRightsEnvironmentAvailable(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(132)]
        public Result GetNsRightsEnvironmentHandle(out ulong arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(140)]
        public Result GetDesirableUids(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<Uid> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(150)]
        public Result ReportApplicationExitTimeout()
        {
            return Result.Success;
        }

        [CmifCommand(160)]
        public Result SetApplicationAttribute([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x20)] ApplicationAttribute arg0)
        {
            return Result.Success;
        }

        [CmifCommand(170)]
        public Result HasSaveDataAccessPermission(out bool arg0, ApplicationId arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(180)]
        public Result PushToFriendInvitationStorageChannel(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(190)]
        public Result PushToNotificationStorageChannel(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(200)]
        public Result RequestApplicationSoftReset()
        {
            return Result.Success;
        }

        [CmifCommand(201)]
        public Result RestartApplicationTimer()
        {
            return Result.Success;
        }
    }
}
