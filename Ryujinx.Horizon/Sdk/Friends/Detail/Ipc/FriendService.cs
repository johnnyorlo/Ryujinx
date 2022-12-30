using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Account;
using Ryujinx.Horizon.Sdk.Settings;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Friends.Detail.Ipc
{
    class FriendService : IFriendService
    {
        [CmifCommand(0)]
        public Result GetCompletionEvent([CopyHandle] out int arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result Cancel()
        {
            return Result.Success;
        }

        [CmifCommand(10100)]
        public Result GetFriendListIds(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<NetworkServiceAccountId> arg1, Uid arg2, int arg3, SizedFriendFilter arg4, ulong arg5)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10101)]
        public Result GetFriendList(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<FriendImpl> arg1, Uid arg2, int arg3, SizedFriendFilter arg4, ulong arg5)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10102)]
        public Result UpdateFriendInfo([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<FriendImpl> arg0, Uid arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<NetworkServiceAccountId> arg2, ulong arg3)
        {
            return Result.Success;
        }

        [CmifCommand(10110)]
        public Result GetFriendProfileImage(out int arg0, Uid arg1, NetworkServiceAccountId arg2, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10120)]
        public Result CheckFriendListAvailability(out bool arg0, Uid arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10121)]
        public Result EnsureFriendListAvailable(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(10200)]
        public Result SendFriendRequestForApplication(Uid arg0, NetworkServiceAccountId arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] InAppScreenName arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] InAppScreenName arg3, ulong arg4)
        {
            return Result.Success;
        }

        [CmifCommand(10211)]
        public Result AddFacedFriendRequestForApplication(Uid arg0, FacedFriendRequestRegistrationKey arg1, Nickname arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg3, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] InAppScreenName arg4, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] InAppScreenName arg5, ulong arg6)
        {
            return Result.Success;
        }

        [CmifCommand(10400)]
        public Result GetBlockedUserListIds(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer)] Span<NetworkServiceAccountId> arg1, Uid arg2, int arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10420)]
        public Result CheckBlockedUserListAvailability(out bool arg0, Uid arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10421)]
        public Result EnsureBlockedUserListAvailable(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(10500)]
        public Result GetProfileList([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ProfileImpl> arg0, Uid arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<NetworkServiceAccountId> arg2)
        {
            return Result.Success;
        }

        [CmifCommand(10600)]
        public Result DeclareOpenOnlinePlaySession(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(10601)]
        public Result DeclareCloseOnlinePlaySession(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(10610)]
        public Result UpdateUserPresence(Uid arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0xE0)] UserPresenceImpl arg1, ulong arg2)
        {
            return Result.Success;
        }

        [CmifCommand(10700)]
        public Result GetPlayHistoryRegistrationKey([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x40)] out PlayHistoryRegistrationKey arg0, Uid arg1, bool arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10701)]
        public Result GetPlayHistoryRegistrationKeyWithNetworkServiceAccountId([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x40)] out PlayHistoryRegistrationKey arg0, NetworkServiceAccountId arg1, bool arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10702)]
        public Result AddPlayHistory(Uid arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x40)] PlayHistoryRegistrationKey arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] InAppScreenName arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] InAppScreenName arg3, ulong arg4)
        {
            return Result.Success;
        }

        [CmifCommand(11000)]
        public Result GetProfileImageUrl(out Url arg0, Url arg1, int arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20100)]
        public Result GetFriendCount(out int arg0, Uid arg1, SizedFriendFilter arg2, ulong arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20101)]
        public Result GetNewlyFriendCount(out int arg0, Uid arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20102)]
        public Result GetFriendDetailedInfo([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x800)] out FriendDetailedInfoImpl arg0, Uid arg1, NetworkServiceAccountId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20103)]
        public Result SyncFriendList(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(20104)]
        public Result RequestSyncFriendList(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(20110)]
        public Result LoadFriendSetting([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x40)] out FriendSettingImpl arg0, Uid arg1, NetworkServiceAccountId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20200)]
        public Result GetReceivedFriendRequestCount(out int arg0, out int arg1, Uid arg2)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(20201)]
        public Result GetFriendRequestList(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<FriendRequestImpl> arg1, Uid arg2, int arg3, int arg4)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20300)]
        public Result GetFriendCandidateList(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<FriendCandidateImpl> arg1, Uid arg2, int arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20301)]
        public Result GetNintendoNetworkIdInfo([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x38)] out NintendoNetworkIdUserInfo arg0, out int arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<NintendoNetworkIdFriendImpl> arg2, Uid arg3, int arg4)
        {
            arg0 = default;
            arg1 = default;

            return Result.Success;
        }

        [CmifCommand(20302)]
        public Result GetSnsAccountLinkage(out SnsAccountLinkage arg0, Uid arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20303)]
        public Result GetSnsAccountProfile([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x380)] out SnsAccountProfile arg0, Uid arg1, NetworkServiceAccountId arg2, int arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20304)]
        public Result GetSnsAccountFriendList(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<SnsAccountFriendImpl> arg1, Uid arg2, int arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20400)]
        public Result GetBlockedUserList(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<BlockedUserImpl> arg1, Uid arg2, int arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20401)]
        public Result SyncBlockedUserList(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(20500)]
        public Result GetProfileExtraList([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<ProfileExtraImpl> arg0, Uid arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<NetworkServiceAccountId> arg2)
        {
            return Result.Success;
        }

        [CmifCommand(20501)]
        public Result GetRelationship(out Relationship arg0, Uid arg1, NetworkServiceAccountId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20600)]
        public Result GetUserPresenceView([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0xE0)] out UserPresenceViewImpl arg0, Uid arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20700)]
        public Result GetPlayHistoryList(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<PlayHistoryImpl> arg1, Uid arg2, int arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20701)]
        public Result GetPlayHistoryStatistics(out PlayHistoryStatistics arg0, Uid arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20800)]
        public Result LoadUserSetting([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x800)] out UserSettingImpl arg0, Uid arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(20801)]
        public Result SyncUserSetting(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(20900)]
        public Result RequestListSummaryOverlayNotification()
        {
            return Result.Success;
        }

        [CmifCommand(21000)]
        public Result GetExternalApplicationCatalog([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x4B8)] out ExternalApplicationCatalog arg0, ExternalApplicationCatalogId arg1, LanguageCode arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(22000)]
        public Result GetReceivedFriendInvitationList(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<FriendInvitationForViewerImpl> arg1, Uid arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(22001)]
        public Result GetReceivedFriendInvitationDetailedInfo([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x1400)] out FriendInvitationGroupImpl arg0, Uid arg1, FriendInvitationGroupId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(22010)]
        public Result GetReceivedFriendInvitationCountCache(out int arg0, Uid arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(30100)]
        public Result DropFriendNewlyFlags(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(30101)]
        public Result DeleteFriend(Uid arg0, NetworkServiceAccountId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30110)]
        public Result DropFriendNewlyFlag(Uid arg0, NetworkServiceAccountId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30120)]
        public Result ChangeFriendFavoriteFlag(Uid arg0, NetworkServiceAccountId arg1, bool arg2)
        {
            return Result.Success;
        }

        [CmifCommand(30121)]
        public Result ChangeFriendOnlineNotificationFlag(Uid arg0, NetworkServiceAccountId arg1, bool arg2)
        {
            return Result.Success;
        }

        [CmifCommand(30200)]
        public Result SendFriendRequest(Uid arg0, NetworkServiceAccountId arg1, int arg2)
        {
            return Result.Success;
        }

        [CmifCommand(30201)]
        public Result SendFriendRequestWithApplicationInfo(Uid arg0, NetworkServiceAccountId arg1, int arg2, ApplicationInfo arg3, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] InAppScreenName arg4, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] InAppScreenName arg5)
        {
            return Result.Success;
        }

        [CmifCommand(30202)]
        public Result CancelFriendRequest(Uid arg0, RequestId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30203)]
        public Result AcceptFriendRequest(Uid arg0, RequestId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30204)]
        public Result RejectFriendRequest(Uid arg0, RequestId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30205)]
        public Result ReadFriendRequest(Uid arg0, RequestId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30210)]
        public Result GetFacedFriendRequestRegistrationKey(out FacedFriendRequestRegistrationKey arg0, Uid arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(30211)]
        public Result AddFacedFriendRequest(Uid arg0, FacedFriendRequestRegistrationKey arg1, Nickname arg2, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg3)
        {
            return Result.Success;
        }

        [CmifCommand(30212)]
        public Result CancelFacedFriendRequest(Uid arg0, NetworkServiceAccountId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30213)]
        public Result GetFacedFriendRequestProfileImage(out int arg0, Uid arg1, NetworkServiceAccountId arg2, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(30214)]
        public Result GetFacedFriendRequestProfileImageFromPath(out int arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg1, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(30215)]
        public Result SendFriendRequestWithExternalApplicationCatalogId(Uid arg0, NetworkServiceAccountId arg1, int arg2, ExternalApplicationCatalogId arg3, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] InAppScreenName arg4, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] InAppScreenName arg5)
        {
            return Result.Success;
        }

        [CmifCommand(30216)]
        public Result ResendFacedFriendRequest(Uid arg0, NetworkServiceAccountId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30217)]
        public Result SendFriendRequestWithNintendoNetworkIdInfo(Uid arg0, NetworkServiceAccountId arg1, int arg2, MiiName arg3, MiiImageUrlParam arg4, MiiName arg5, MiiImageUrlParam arg6)
        {
            return Result.Success;
        }

        [CmifCommand(30300)]
        public Result GetSnsAccountLinkPageUrl([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias, 0x1000)] out WebPageUrl arg0, Uid arg1, int arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(30301)]
        public Result UnlinkSnsAccount(Uid arg0, int arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30400)]
        public Result BlockUser(Uid arg0, NetworkServiceAccountId arg1, int arg2)
        {
            return Result.Success;
        }

        [CmifCommand(30401)]
        public Result BlockUserWithApplicationInfo(Uid arg0, NetworkServiceAccountId arg1, int arg2, ApplicationInfo arg3, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer, 0x48)] InAppScreenName arg4)
        {
            return Result.Success;
        }

        [CmifCommand(30402)]
        public Result UnblockUser(Uid arg0, NetworkServiceAccountId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30500)]
        public Result GetProfileExtraFromFriendCode([Buffer(HipcBufferFlags.Out | HipcBufferFlags.Pointer, 0x400)] out ProfileExtraImpl arg0, Uid arg1, FriendCode arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(30700)]
        public Result DeletePlayHistory(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(30810)]
        public Result ChangePresencePermission(Uid arg0, int arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30811)]
        public Result ChangeFriendRequestReception(Uid arg0, bool arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30812)]
        public Result ChangePlayLogPermission(Uid arg0, int arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30820)]
        public Result IssueFriendCode(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(30830)]
        public Result ClearPlayLog(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(30900)]
        public Result SendFriendInvitation(Uid arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<NetworkServiceAccountId> arg1, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias, 0xC00)] FriendInvitationGameModeDescription arg2, ApplicationInfo arg3, [Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg4, bool arg5)
        {
            return Result.Success;
        }

        [CmifCommand(30910)]
        public Result ReadFriendInvitation(Uid arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<FriendInvitationId> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30911)]
        public Result ReadAllFriendInvitations(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(40100)]
        public Result DeleteFriendListCache(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(40400)]
        public Result DeleteBlockedUserListCache(Uid arg0)
        {
            return Result.Success;
        }

        [CmifCommand(49900)]
        public Result DeleteNetworkServiceAccountCache(Uid arg0)
        {
            return Result.Success;
        }
    }
}
