using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Ncm;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class ApplicationCreator : IApplicationCreator
    {
        [CmifCommand(0)]
        public Result CreateApplication(out IApplicationAccessor arg0, ApplicationId arg1)
        {
            arg0 = new ApplicationAccessor();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result PopLaunchRequestedApplication(out IApplicationAccessor arg0)
        {
            arg0 = new ApplicationAccessor();

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result CreateSystemApplication(out IApplicationAccessor arg0, SystemApplicationId arg1)
        {
            arg0 = new ApplicationAccessor();

            return Result.Success;
        }

        [CmifCommand(100)]
        public Result PopFloatingApplicationForDevelopment(out IApplicationAccessor arg0)
        {
            arg0 = new ApplicationAccessor();

            return Result.Success;
        }
    }
}
