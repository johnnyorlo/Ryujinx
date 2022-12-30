using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Bcat.Ipc
{
    interface IBcatService : IServiceObject
    {
        Result RequestSyncDeliveryCache(out IDeliveryCacheProgressService arg0);
        Result RequestSyncDeliveryCacheWithDirectoryName(out IDeliveryCacheProgressService arg0, DirectoryName arg1);
        Result CancelSyncDeliveryCacheRequest();
        Result RequestSyncDeliveryCacheWithApplicationId(out IDeliveryCacheProgressService arg0, ApplicationId arg1, uint arg2);
        Result RequestSyncDeliveryCacheWithApplicationIdAndDirectoryName(out IDeliveryCacheProgressService arg0, ApplicationId arg1, uint arg2, DirectoryName arg3);
        Result GetDeliveryCacheStorageUpdateNotifier(out INotifierService arg0, ApplicationId arg1);
        Result RequestSuspendDeliveryTask(out IDeliveryTaskSuspensionService arg0, ApplicationId arg1);
        Result RegisterSystemApplicationDeliveryTask(ApplicationId arg0);
        Result UnregisterSystemApplicationDeliveryTask(ApplicationId arg0);
        Result SetSystemApplicationDeliveryTaskTimer(ApplicationId arg0, int arg1, int arg2);
        Result SetPassphrase(ApplicationId arg0, ReadOnlySpan<sbyte> arg1);
        Result RegisterDeliveryTask(ApplicationId arg0, uint arg1);
        Result UnregisterDeliveryTask(ApplicationId arg0);
        Result BlockDeliveryTask(ApplicationId arg0);
        Result UnblockDeliveryTask(ApplicationId arg0);
        Result SetDeliveryTaskTimer(ApplicationId arg0, int arg1, int arg2);
        Result RegisterSystemApplicationDeliveryTasks();
        Result GetDeliveryTaskList(out int arg0, Span<TaskInfo> arg1);
        Result GetDeliveryTaskListForSystem(out int arg0, Span<TaskInfo> arg1);
        Result GetDeliveryList(out ulong arg0, Span<byte> arg1, ApplicationId arg2);
        Result ClearDeliveryCacheStorage(ApplicationId arg0);
        Result ClearDeliveryTaskSubscriptionStatus();
        Result GetPushNotificationLog(out int arg0, Span<PushNotificationLog> arg1);
        Result GetDeliveryCacheStorageUsage(out DeliveryCacheStorageUsage arg0, ApplicationId arg1);
    }
}
