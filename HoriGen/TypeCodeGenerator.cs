using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HoriGen
{
    static class TypeCodeGenerator
    {
        public static string Generate(TypeDefinition typeDefinition)
        {
            string declKeyword = typeDefinition.Kind switch
            {
                TypeKind.Interface => "interface",
                TypeKind.Class => "class",
                TypeKind.Structure => "struct",
                _ => throw new NotImplementedException(typeDefinition.Kind.ToString())
            };

            CodeGenerator generator = new CodeGenerator();

            (string namespaceName, string typeName) = SplitTypeAndNamespace(typeDefinition.Name);

            AddImports(generator, typeDefinition, namespaceName);

            generator.EnterScope($"namespace {namespaceName}");

            if (typeDefinition.Kind == TypeKind.Structure && (typeDefinition.StructSize | typeDefinition.StructAlignment) != 0)
            {
                if (typeDefinition.StructAlignment != 0)
                {
                    generator.AppendLine($"[StructLayout(LayoutKind.Sequential, Size = 0x{typeDefinition.StructSize:X}, Pack = 0x{typeDefinition.StructAlignment:X})]");
                }
                else
                {
                    generator.AppendLine($"[StructLayout(LayoutKind.Sequential, Size = 0x{typeDefinition.StructSize:X})]");
                }
            }

            generator.EnterScope($"{declKeyword} {typeName}{GetImplementList(typeDefinition)}");

            bool firstMember = true;

            foreach (var member in typeDefinition.GetMembers())
            {
                DeclareMember(generator, typeDefinition.Kind, member, firstMember);

                firstMember = false;
            }

            generator.LeaveScope();
            generator.LeaveScope();

            return generator.ToString();
        }

        private static void AddImports(CodeGenerator generator, TypeDefinition typeDefinition, string ownNamespace)
        {
            bool hasAny = false;

            foreach (var import in typeDefinition.GetImports().Order())
            {
                if (ownNamespace.StartsWith(import) &&
                    (ownNamespace.Length == import.Length ||
                    ownNamespace[import.Length] == '.'))
                {
                    continue;
                }

                generator.AppendLine($"using {import};");
                hasAny = true;
            }

            if (hasAny)
            {
                generator.AppendLine();
            }
        }

        private static string GetImplementList(TypeDefinition typeDefinition)
        {
            List<string> parts = new List<string>();

            foreach (var implement in typeDefinition.GetImplements())
            {
                (_, string typeName) = SplitTypeAndNamespace(implement);
                parts.Add(typeName);
            }

            if (parts.Count == 0)
            {
                return string.Empty;
            }

            return " : " + string.Join(", ", parts);
        }

        private static void DeclareMember(CodeGenerator generator, TypeKind typeKind, MemberDefinition member, bool isFirstMember)
        {
            switch (member.Kind)
            {
                case MemberKind.Method:
                    if (typeKind == TypeKind.Interface)
                    {
                        generator.AppendLine($"Result {member.Name}({GetMethodParameterList((MethodDefinition)member, false)});");
                    }
                    else if (typeKind == TypeKind.Class)
                    {
                        if (!isFirstMember)
                        {
                            generator.AppendLine();
                        }

                        var methodDef = (MethodDefinition)member;

                        if (methodDef.CommandId >= 0)
                        {
                            generator.AppendLine($"[CmifCommand({methodDef.CommandId})]");
                        }
                        else
                        {
                            generator.AppendLine("// Could not determine command ID, please fill it in manually");
                        }
                        
                        generator.EnterScope($"public Result {member.Name}({GetMethodParameterList(methodDef, true)})");

                        bool hasAnyOutArg = false;

                        for (int i = 0; i < methodDef.Parameters.Length; i++)
                        {
                            if (methodDef.Parameters[i].Direction == Direction.Out)
                            {
                                (_, string typeName) = SplitTypeAndNamespace(methodDef.Parameters[i].TypeName);

                                if (methodDef.Parameters[i].CommandArgType == CommandArgType.Object && NameConverter.IsInterfaceName(typeName))
                                {
                                    generator.AppendLine($"{methodDef.Parameters[i].Name} = new {typeName.Substring(1)}();");
                                }
                                else
                                {
                                    generator.AppendLine($"{methodDef.Parameters[i].Name} = default;");
                                }

                                hasAnyOutArg = true;
                            }
                        }

                        if (hasAnyOutArg)
                        {
                            generator.AppendLine();
                        }

                        generator.AppendLine("return Result.Success;");
                        generator.LeaveScope();
                    }
                    break;
            }
        }

        private static string GetMethodParameterList(MethodDefinition methodDefinition, bool includeAttributes)
        {
            string[] parts = new string[methodDefinition.Parameters.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                var parameter = methodDefinition.Parameters[i];
                (_, var typeName) = SplitTypeAndNamespace(parameter.TypeName);

                if (parameter.WrapperTypeName != null)
                {
                    (_, var wrapperTypeName) = SplitTypeAndNamespace(parameter.WrapperTypeName);
                    typeName = $"{wrapperTypeName}<{typeName}>";
                }

                string modifier = string.Empty;

                if (parameter.Direction == Direction.Out)
                {
                    modifier = "out ";
                }
                else if (parameter.CommandArgType == CommandArgType.Buffer &&
                         parameter.WrapperTypeName == null &&
                         parameter.IsCustomType)
                {
                    modifier = "in ";
                }

                string attributeList = string.Empty;

                if (includeAttributes)
                {
                    switch (parameter.CommandArgType)
                    {
                        case CommandArgType.Buffer:
                            if (parameter.BufferFlags.HasFlag(HipcBufferFlags.FixedSize))
                            {
                                attributeList = $"[Buffer({GetFlagsMask(parameter.BufferFlags & ~HipcBufferFlags.FixedSize)}, 0x{parameter.BufferFixedSize:X})] ";
                            }
                            else
                            {
                                attributeList = $"[Buffer({GetFlagsMask(parameter.BufferFlags)})] ";
                            }
                            break;
                        case CommandArgType.CopyHandle:
                            attributeList = "[CopyHandle] ";
                            break;
                        case CommandArgType.MoveHandle:
                            attributeList = "[MoveHandle] ";
                            break;
                        case CommandArgType.ClientProcessId:
                            attributeList = "[ClientProcessId] ";
                            break;
                    }
                }

                parts[i] = $"{attributeList}{modifier}{typeName} {parameter.Name}";
            }

            return string.Join(", ", parts);
        }

        private static string GetFlagsMask(HipcBufferFlags flags)
        {
            string[] parts = new string[BitOperations.PopCount((uint)flags)];
            int outputIndex = 0;

            for (int i = 0; i < 8; i++)
            {
                int mask = 1 << i;
                if (((int)flags & mask) != 0)
                {
                    parts[outputIndex++] = $"HipcBufferFlags.{(HipcBufferFlags)mask}";
                }
            }

            return string.Join(" | ", parts);
        }

        public static (string, string) SplitTypeAndNamespace(string fullName)
        {
            int splitIndex = fullName.LastIndexOf('.');
            if (splitIndex < 0)
            {
                return (string.Empty, fullName);
            }

            return (fullName.Substring(0, splitIndex), fullName.Substring(splitIndex + 1));
        }
    }
}
