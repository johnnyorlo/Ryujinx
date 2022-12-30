using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Npns
{
    class CreateTokenAsyncContext : ICreateTokenAsyncContext
    {
        [CmifCommand(10)]
        public Result GetNotificationToken(out NotificationToken arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
