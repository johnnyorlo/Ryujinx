using System.Collections.Generic;

namespace HoriGen
{
    internal class TypeDefinition
    {
        public readonly TypeKind Kind;
        public readonly string Name;

        public int StructSize;
        public int StructAlignment;

        private readonly HashSet<string> _imports;
        private readonly List<string> _implements;
        private readonly List<MemberDefinition> _members;
        private readonly HashSet<string> _existingMemberNames;

        public TypeDefinition(TypeKind kind, string name)
        {
            Kind = kind;
            Name = name;
            _imports = new HashSet<string>();
            _implements = new List<string>();
            _members = new List<MemberDefinition>();
            _existingMemberNames = new HashSet<string>();
        }

        public void AddMember(MemberDefinition member)
        {
            if (!_existingMemberNames.Add(member.Name))
            {
                return;
            }

            _members.Add(member);
        }

        public void AddMembers(IEnumerable<MemberDefinition> members)
        {
            _members.AddRange(members);
        }

        public void AddImport(string import)
        {
            _imports.Add(import);
        }

        public void AddImports(IEnumerable<string> imports)
        {
            _imports.UnionWith(imports);
        }

        public void AddImplement(string implement)
        {
            _implements.Add(implement);
        }

        public IEnumerable<MemberDefinition> GetMembers()
        {
            return _members;
        }

        public IEnumerable<string> GetImports()
        {
            return _imports;
        }

        public IEnumerable<string> GetImplements()
        {
            return _implements;
        }
    }
}
