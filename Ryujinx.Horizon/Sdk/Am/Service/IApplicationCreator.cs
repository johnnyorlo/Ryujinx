using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IApplicationCreator : IServiceObject
    {
        Result CreateApplication(out IApplicationAccessor arg0, ApplicationId arg1);
        Result PopLaunchRequestedApplication(out IApplicationAccessor arg0);
        Result CreateSystemApplication(out IApplicationAccessor arg0, SystemApplicationId arg1);
        Result PopFloatingApplicationForDevelopment(out IApplicationAccessor arg0);
    }
}
