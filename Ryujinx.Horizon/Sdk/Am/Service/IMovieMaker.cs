using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Grcsrv;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    interface IMovieMaker : IServiceObject
    {
        Result GetGrcMovieMaker(out IMovieMaker arg0);
        Result GetLayerHandle(out ulong arg0);
    }
}
