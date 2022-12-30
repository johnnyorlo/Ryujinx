using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoriGen
{
    struct MethodParameter
    {
        public readonly Direction Direction;
        public readonly string WrapperTypeName;
        public readonly string TypeName;
        public readonly bool IsCustomType;
        public readonly string Name;

        public CommandArgType CommandArgType;
        public HipcBufferFlags BufferFlags;
        public ushort BufferFixedSize;

        public MethodParameter(Direction direction, string wrapperTypeName, string typeName, bool isCustomType, string name)
        {
            Direction = direction;
            WrapperTypeName = wrapperTypeName;
            TypeName = typeName;
            IsCustomType = isCustomType;
            Name = name;
        }
    }
}
