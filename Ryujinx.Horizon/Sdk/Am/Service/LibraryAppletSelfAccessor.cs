using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Err;
using Ryujinx.Horizon.Sdk.Grcsrv;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Ns;
using Ryujinx.Horizon.Sdk.Settings;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class LibraryAppletSelfAccessor : ILibraryAppletSelfAccessor
    {
        [CmifCommand(0)]
        public Result PopInData(out IStorage arg0)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result PushOutData(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(2)]
        public Result PopInteractiveInData(out IStorage arg0)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result PushInteractiveOutData(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(5)]
        public Result GetPopInDataEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(6)]
        public Result GetPopInteractiveInDataEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result ExitProcessAndReturn()
        {
            return Result.Success;
        }

        [CmifCommand(11)]
        public Result GetLibraryAppletInfo(out LibraryAppletInfo arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(12)]
        public Result GetMainAppletIdentityInfo(out AppletIdentityInfo arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(13)]
        public Result CanUseApplicationCore(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(14)]
        public Result GetCallerAppletIdentityInfo(out AppletIdentityInfo arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(15)]
        public Result GetMainAppletApplicationControlProperty([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x4000)] out ApplicationControlProperty arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(16)]
        public Result GetMainAppletStorageId(out StorageId arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(17)]
        public Result GetCallerAppletIdentityInfoStack(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<AppletIdentityInfo> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(18)]
        public Result GetNextReturnDestinationAppletIdentityInfo(out AppletIdentityInfo arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(19)]
        public Result GetDesirableKeyboardLayout(out uint arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20)]
        public Result PopExtraStorage(out IStorage arg0)
        {
            arg0 = new Storage();

            return Result.Success;
        }

        [CmifCommand(25)]
        public Result GetPopExtraStorageEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(30)]
        public Result UnpopInData(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(31)]
        public Result UnpopExtraStorage(IStorage arg0)
        {
            return Result.Success;
        }

        [CmifCommand(40)]
        public Result GetIndirectLayerProducerHandle(out ulong arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(50)]
        public Result ReportVisibleError(ErrorCode arg0)
        {
            return Result.Success;
        }

        [CmifCommand(51)]
        public Result ReportVisibleErrorWithErrorContext(ErrorCode arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0x200)] ErrorContext arg1)
        {
            return Result.Success;
        }

        [CmifCommand(60)]
        public Result GetMainAppletApplicationDesiredLanguage(out LanguageCode arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(70)]
        public Result GetCurrentApplicationId(out ApplicationId arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(80)]
        public Result RequestExitToSelf()
        {
            return Result.Success;
        }

        [CmifCommand(90)]
        public Result CreateApplicationAndPushAndRequestToLaunch(ApplicationId arg0, IStorage arg1)
        {
            return Result.Success;
        }

        [CmifCommand(100)]
        public Result CreateGameMovieTrimmer(out IGameMovieTrimmer arg0, [CopyHandle] int arg1, ulong arg2)
        {
            arg0 = new GameMovieTrimmer();

            return Result.Success;
        }

        [CmifCommand(101)]
        public Result ReserveResourceForMovieOperation()
        {
            return Result.Success;
        }

        [CmifCommand(102)]
        public Result UnreserveResourceForMovieOperation()
        {
            return Result.Success;
        }

        [CmifCommand(110)]
        public Result GetMainAppletAvailableUsers(out bool arg0, out int arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<Uid> arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(120)]
        public Result GetLaunchStorageInfoForDebug(out StorageId arg0, out StorageId arg1)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(130)]
        public Result GetGpuErrorDetectedSystemEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(140)]
        public Result SetApplicationMemoryReservation(ulong arg0)
        {
            return Result.Success;
        }

        [CmifCommand(150)]
        public Result ShouldSetGpuTimeSliceManually(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
