using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using Ryujinx.Horizon.Sdk.Sf.Hipc;
using System;

namespace Ryujinx.Horizon.Sdk.Mii.Detail
{
    class DatabaseService : IDatabaseService
    {
        [CmifCommand(0)]
        public Result IsUpdated(out bool arg0, int arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(1)]
        public Result IsFullDatabase(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(2)]
        public Result GetCount(out int arg0, int arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(3)]
        public Result Get(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<CharInfoElement> arg1, int arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(4)]
        public Result Get1(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<CharInfo> arg1, int arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(5)]
        public Result UpdateLatest(out CharInfo arg0, CharInfo arg1, int arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(6)]
        public Result BuildRandom(out CharInfo arg0, int arg1, int arg2, int arg3)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(7)]
        public Result BuildDefault(out CharInfo arg0, int arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(8)]
        public Result Get2(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<StoreDataElement> arg1, int arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(9)]
        public Result Get3(out int arg0, [Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<StoreData> arg1, int arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(10)]
        public Result UpdateLatest1(out StoreData arg0, StoreData arg1, int arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(11)]
        public Result FindIndex(out int arg0, CreateId arg1, bool arg2)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(12)]
        public Result Move(int arg0, CreateId arg1)
        {
            return Result.Success;
        }

        [CmifCommand(13)]
        public Result AddOrReplace(StoreData arg0)
        {
            return Result.Success;
        }

        [CmifCommand(14)]
        public Result Delete(CreateId arg0)
        {
            return Result.Success;
        }

        [CmifCommand(15)]
        public Result DestroyFile()
        {
            return Result.Success;
        }

        [CmifCommand(16)]
        public Result DeleteFile()
        {
            return Result.Success;
        }

        [CmifCommand(17)]
        public Result Format()
        {
            return Result.Success;
        }

        [CmifCommand(18)]
        public Result Import([Buffer(HipcBufferFlags.In | HipcBufferFlags.MapAlias)] ReadOnlySpan<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(19)]
        public Result Export([Buffer(HipcBufferFlags.Out | HipcBufferFlags.MapAlias)] Span<byte> arg0)
        {
            return Result.Success;
        }

        [CmifCommand(20)]
        public Result IsBrokenDatabaseWithClearFlag(out bool arg0)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(21)]
        public Result GetIndex(out int arg0, CharInfo arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(22)]
        public Result SetInterfaceVersion(int arg0)
        {
            return Result.Success;
        }

        [CmifCommand(23)]
        public Result Convert(out CharInfo arg0, Ver3StoreData arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(24)]
        public Result ConvertCoreDataToCharInfo(out CharInfo arg0, CoreData arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(25)]
        public Result ConvertCharInfoToCoreData(out CoreData arg0, CharInfo arg1)
        {
            arg0 = default;

            return Result.Success;
        }

        [CmifCommand(26)]
        public Result Append(CharInfo arg0)
        {
            return Result.Success;
        }
    }
}
