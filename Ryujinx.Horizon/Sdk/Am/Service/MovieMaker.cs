using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Grcsrv;
using Ryujinx.Horizon.Sdk.Sf;

namespace Ryujinx.Horizon.Sdk.Am.Service
{
    class MovieMaker : IMovieMaker
    {
        [CmifCommand(0)]
        public Result GetGrcMovieMaker(out IMovieMaker arg0)
        {
            arg0 = new MovieMaker();

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result GetLayerHandle(out ulong arg0)
        {
            arg0 = default;

            return Result.Success;
        }
    }
}
