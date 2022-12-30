using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface ILockAccessor : IServiceObject
    {
        Result TryLock(out bool arg0, out int arg1, bool arg2);
        Result Unlock();
        Result GetEvent(out int arg0);
        Result IsLocked(out bool arg0);
    }
}
