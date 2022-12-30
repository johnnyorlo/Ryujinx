using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Err;
using Ryujinx.Horizon.Sdk.Grcsrv;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Ns;
using Ryujinx.Horizon.Sdk.Settings;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface ILibraryAppletSelfAccessor : IServiceObject
    {
        Result PopInData(out IStorage arg0);
        Result PushOutData(IStorage arg0);
        Result PopInteractiveInData(out IStorage arg0);
        Result PushInteractiveOutData(IStorage arg0);
        Result GetPopInDataEvent(out int arg0);
        Result GetPopInteractiveInDataEvent(out int arg0);
        Result ExitProcessAndReturn();
        Result GetLibraryAppletInfo(out LibraryAppletInfo arg0);
        Result GetMainAppletIdentityInfo(out AppletIdentityInfo arg0);
        Result CanUseApplicationCore(out bool arg0);
        Result GetCallerAppletIdentityInfo(out AppletIdentityInfo arg0);
        Result GetMainAppletApplicationControlProperty(out ApplicationControlProperty arg0);
        Result GetMainAppletStorageId(out StorageId arg0);
        Result GetCallerAppletIdentityInfoStack(out int arg0, Span<AppletIdentityInfo> arg1);
        Result GetNextReturnDestinationAppletIdentityInfo(out AppletIdentityInfo arg0);
        Result GetDesirableKeyboardLayout(out uint arg0);
        Result PopExtraStorage(out IStorage arg0);
        Result GetPopExtraStorageEvent(out int arg0);
        Result UnpopInData(IStorage arg0);
        Result UnpopExtraStorage(IStorage arg0);
        Result GetIndirectLayerProducerHandle(out ulong arg0);
        Result ReportVisibleError(ErrorCode arg0);
        Result ReportVisibleErrorWithErrorContext(ErrorCode arg0, ErrorContext arg1);
        Result GetMainAppletApplicationDesiredLanguage(out LanguageCode arg0);
        Result GetCurrentApplicationId(out ApplicationId arg0);
        Result RequestExitToSelf();
        Result CreateApplicationAndPushAndRequestToLaunch(ApplicationId arg0, IStorage arg1);
        Result CreateGameMovieTrimmer(out IGameMovieTrimmer arg0, int arg1, ulong arg2);
        Result ReserveResourceForMovieOperation();
        Result UnreserveResourceForMovieOperation();
        Result GetMainAppletAvailableUsers(out bool arg0, out int arg1, Span<Uid> arg2);
        Result GetLaunchStorageInfoForDebug(out StorageId arg0, out StorageId arg1);
        Result GetGpuErrorDetectedSystemEvent(out int arg0);
        Result SetApplicationMemoryReservation(ulong arg0);
        Result ShouldSetGpuTimeSliceManually(out bool arg0);
    }
}
