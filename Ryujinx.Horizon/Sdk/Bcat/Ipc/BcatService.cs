using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Bcat.Ipc
{
    class BcatService : IBcatService
    {
        [CmifCommand(10100)]
        public Result RequestSyncDeliveryCache(out IDeliveryCacheProgressService arg0)
        {
            arg0 = new DeliveryCacheProgressService();

            return Result.Success;
        }

        [CmifCommand(10101)]
        public Result RequestSyncDeliveryCacheWithDirectoryName(out IDeliveryCacheProgressService arg0, DirectoryName arg1)
        {
            arg0 = new DeliveryCacheProgressService();

            return Result.Success;
        }

        [CmifCommand(10200)]
        public Result CancelSyncDeliveryCacheRequest()
        {
            return Result.Success;
        }

        [CmifCommand(20100)]
        public Result RequestSyncDeliveryCacheWithApplicationId(out IDeliveryCacheProgressService arg0, ApplicationId arg1, uint arg2)
        {
            arg0 = new DeliveryCacheProgressService();

            return Result.Success;
        }

        [CmifCommand(20101)]
        public Result RequestSyncDeliveryCacheWithApplicationIdAndDirectoryName(out IDeliveryCacheProgressService arg0, ApplicationId arg1, uint arg2, DirectoryName arg3)
        {
            arg0 = new DeliveryCacheProgressService();

            return Result.Success;
        }

        [CmifCommand(20300)]
        public Result GetDeliveryCacheStorageUpdateNotifier(out INotifierService arg0, ApplicationId arg1)
        {
            arg0 = new NotifierService();

            return Result.Success;
        }

        [CmifCommand(20301)]
        public Result RequestSuspendDeliveryTask(out IDeliveryTaskSuspensionService arg0, ApplicationId arg1)
        {
            arg0 = new DeliveryTaskSuspensionService();

            return Result.Success;
        }

        [CmifCommand(20400)]
        public Result RegisterSystemApplicationDeliveryTask(ApplicationId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(20401)]
        public Result UnregisterSystemApplicationDeliveryTask(ApplicationId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(20410)]
        public Result SetSystemApplicationDeliveryTaskTimer(ApplicationId arg0, int arg1, int arg2)
        {
            return Result.Success;
        }

        [CmifCommand(30100)]
        public Result SetPassphrase(ApplicationId arg0, [Buffer(HipcBufferFlags.In | HipcBufferFlags.Pointer)] ReadOnlySpan<sbyte> arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30200)]
        public Result RegisterDeliveryTask(ApplicationId arg0, uint arg1)
        {
            return Result.Success;
        }

        [CmifCommand(30201)]
        public Result UnregisterDeliveryTask(ApplicationId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(30202)]
        public Result BlockDeliveryTask(ApplicationId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(30203)]
        public Result UnblockDeliveryTask(ApplicationId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(30210)]
        public Result SetDeliveryTaskTimer(ApplicationId arg0, int arg1, int arg2)
        {
            return Result.Success;
        }

        [CmifCommand(30300)]
        public Result RegisterSystemApplicationDeliveryTasks()
        {
            return Result.Success;
        }

        [CmifCommand(90100)]
        public Result GetDeliveryTaskList(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<TaskInfo> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(90101)]
        public Result GetDeliveryTaskListForSystem(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<TaskInfo> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(90200)]
        public Result GetDeliveryList(out ulong arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg1, ApplicationId arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(90201)]
        public Result ClearDeliveryCacheStorage(ApplicationId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(90202)]
        public Result ClearDeliveryTaskSubscriptionStatus()
        {
            return Result.Success;
        }

        [CmifCommand(90300)]
        public Result GetPushNotificationLog(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<PushNotificationLog> arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(90301)]
        public Result GetDeliveryCacheStorageUsage(out DeliveryCacheStorageUsage arg0, ApplicationId arg1)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
