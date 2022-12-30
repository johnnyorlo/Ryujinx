using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoriGen
{
    internal class MethodDefinition : MemberDefinition
    {
        public readonly MethodParameter[] Parameters;
        public readonly int CommandId;

        public MethodDefinition(string name, MethodParameter[] parameters, int commandId) : base(MemberKind.Method, name)
        {
            Parameters = parameters;
            CommandId = commandId;
        }
    }
}
