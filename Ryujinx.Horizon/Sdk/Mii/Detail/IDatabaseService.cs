using Ryujinx.Horizon.Common;
using Ryujinx.Horizon.Sdk.Sf;
using System;

namespace Ryujinx.Horizon.Sdk.Mii.Detail
{
    interface IDatabaseService : IServiceObject
    {
        Result IsUpdated(out bool arg0, int arg1);
        Result IsFullDatabase(out bool arg0);
        Result GetCount(out int arg0, int arg1);
        Result Get(out int arg0, Span<CharInfoElement> arg1, int arg2);
        Result Get1(out int arg0, Span<CharInfo> arg1, int arg2);
        Result UpdateLatest(out CharInfo arg0, CharInfo arg1, int arg2);
        Result BuildRandom(out CharInfo arg0, int arg1, int arg2, int arg3);
        Result BuildDefault(out CharInfo arg0, int arg1);
        Result Get2(out int arg0, Span<StoreDataElement> arg1, int arg2);
        Result Get3(out int arg0, Span<StoreData> arg1, int arg2);
        Result UpdateLatest1(out StoreData arg0, StoreData arg1, int arg2);
        Result FindIndex(out int arg0, CreateId arg1, bool arg2);
        Result Move(int arg0, CreateId arg1);
        Result AddOrReplace(StoreData arg0);
        Result Delete(CreateId arg0);
        Result DestroyFile();
        Result DeleteFile();
        Result Format();
        Result Import(ReadOnlySpan<byte> arg0);
        Result Export(Span<byte> arg0);
        Result IsBrokenDatabaseWithClearFlag(out bool arg0);
        Result GetIndex(out int arg0, CharInfo arg1);
        Result SetInterfaceVersion(int arg0);
        Result Convert(out CharInfo arg0, Ver3StoreData arg1);
        Result ConvertCoreDataToCharInfo(out CharInfo arg0, CoreData arg1);
        Result ConvertCharInfoToCoreData(out CoreData arg0, CharInfo arg1);
        Result Append(CharInfo arg0);
    }
}
