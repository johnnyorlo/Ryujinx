using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf.Cmif;

namespace Ryujinx.Horizon.Sdk.Sf.Hipc.Detail
{
    interface IHipcManager : IServiceObject
    {
        Result ConvertCurrentObjectToDomain(out CmifDomainObjectId arg0);
        Result CopyFromCurrentDomain(out int arg0, CmifDomainObjectId arg1);
        Result CloneCurrentObject(out int arg0);
        Result QueryPointerBufferSize(out ushort arg0);
        Result CloneCurrentObjectEx(out int arg0, uint arg1);
    }
}
