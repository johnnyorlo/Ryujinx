using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoriGen
{
    [Flags]
    enum HipcBufferFlags : byte
    {
        In = 1 << 0,
        Out = 1 << 1,
        MapAlias = 1 << 2,
        Pointer = 1 << 3,
        FixedSize = 1 << 4,
        AutoSelect = 1 << 5,
        MapTransferAllowsNonSecure = 1 << 6,
        MapTransferAllowsNonDevice = 1 << 7
    }
}
