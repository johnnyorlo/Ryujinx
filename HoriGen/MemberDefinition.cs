using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoriGen
{
    internal class MemberDefinition
    {
        public readonly MemberKind Kind;
        public readonly string Name;

        protected MemberDefinition(MemberKind kind, string name)
        {
            Kind = kind;
            Name = name;
        }
    }
}
