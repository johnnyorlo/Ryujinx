using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoriGen
{
    static class FunctionSignatureParser
    {
        public struct FunctionInfo
        {
            public readonly string ContainingType;
            public readonly string Name;
            public readonly string[] ParameterTypes;

            public FunctionInfo(string containingType, string name, string[] parameters)
            {
                ContainingType = containingType;
                Name = name;
                ParameterTypes = parameters;
            }
        }

        public static FunctionInfo Parse(string functionSignature)
        {
            string[] namespaceParts = Parser.Split(functionSignature, "::");

            if (namespaceParts.Length == 0)
            {
                return default;
            }

            string functionName = namespaceParts[namespaceParts.Length - 1];
            string[] functionParams = Array.Empty<string>();

            string[] subParts = new string[namespaceParts.Length - 1];
            namespaceParts.AsSpan().Slice(0, namespaceParts.Length - 1).CopyTo(subParts);

            int paramsStartIndex = functionName.IndexOf('(');
            int paramsEndIndex = paramsStartIndex >= 0 ? functionName.IndexOf(')', paramsStartIndex) : -1;

            if (paramsEndIndex > paramsStartIndex)
            {
                string paramsPart = functionName.Substring(paramsStartIndex + 1, paramsEndIndex - (paramsStartIndex + 1));

                functionName = functionName.Substring(0, paramsStartIndex);

                string[] paramsParts = Parser.Split(paramsPart, ",");
                functionParams = new string[paramsParts.Length];

                for (int i = 0; i < paramsParts.Length; i++)
                {
                    functionParams[i] = paramsParts[i].Trim();
                }
            }

            return new FunctionInfo(string.Join("::", subParts), functionName, functionParams);
        }

        public static MethodParameter ParseParameter(TypeMaterializer materializer, TypeDefinition typeDef, string parameterTypeName, int paramIndex)
        {
            Direction direction = Direction.In;
            string wrapperCSharpType = null;

            void ParseTemplate(string template, int nestingLevel)
            {
                if (nestingLevel == 0)
                {
                    switch (template)
                    {
                        case "nn::sf::Out":
                            direction = Direction.Out;
                            return;
                        case "nn::sf::InArray":
                            wrapperCSharpType = "System.ReadOnlySpan";
                            return;
                        case "nn::sf::OutArray":
                            wrapperCSharpType = "System.Span";
                            return;
                    }
                }
            }

            (string unwrap0, string typeName) = UnwrapSingle(parameterTypeName);

            ParseTemplate(unwrap0, 0);

            if (typeName != parameterTypeName)
            {
                (string unwrap1, typeName) = UnwrapSingle(typeName);

                ParseTemplate(unwrap1, 1);
            }

            typeName = NameConverter.GetCSharpTypeName(Filter(typeName), out bool isCustomType);

            (string typeNamespaceName, _) = TypeCodeGenerator.SplitTypeAndNamespace(typeName);

            if (!string.IsNullOrEmpty(typeNamespaceName))
            {
                typeDef.AddImport(typeNamespaceName);
            }

            if (!string.IsNullOrEmpty(wrapperCSharpType))
            {
                (typeNamespaceName, _) = TypeCodeGenerator.SplitTypeAndNamespace(wrapperCSharpType);

                if (!string.IsNullOrEmpty(typeNamespaceName))
                {
                    typeDef.AddImport(typeNamespaceName);
                }
            }

            return new MethodParameter(direction, wrapperCSharpType, typeName, isCustomType, $"arg{paramIndex}");
        }

        private static string Filter(string typeName)
        {
            string ConstPtr = "const&";

            if (typeName.EndsWith(ConstPtr))
            {
                typeName = typeName.Substring(0, typeName.Length - ConstPtr.Length);
            }

            while (typeName.EndsWith('&'))
            {
                typeName = typeName.Substring(0, typeName.Length - 1);
            }

            return typeName.TrimEnd();
        }

        public static void ParseAdditionalParameterInfo(TypeMaterializer materializer, string processFunctionSignature, ref MethodParameter[] funcParams)
        {
            string[] namespaceParts = Parser.Split(processFunctionSignature, "::");

            if (namespaceParts.Length == 0)
            {
                return;
            }

            string[] subParts = new string[namespaceParts.Length - 1];
            namespaceParts.AsSpan().Slice(0, namespaceParts.Length - 1).CopyTo(subParts);

            string template = string.Join("::", subParts);

            (_, string subTemplate1) = UnwrapAt(template, 1);
            (_, string subTemplate2) = UnwrapAt(subTemplate1, 0);
            (_, string sendPid) = UnwrapAt(subTemplate1, 3);

            (string tupleName, string tupleContent) = Unwrap(subTemplate2);
            string[] tupleParts = Parser.Split(tupleContent, ",");

            if (sendPid.Trim() == "true" && funcParams.Length > 0)
            {
                int pidIndex = funcParams.Length;
                Array.Resize(ref funcParams, pidIndex + 1);
                funcParams[pidIndex] = new MethodParameter(Direction.In, null, "ulong", false, "pid")
                {
                    CommandArgType = CommandArgType.ClientProcessId
                };
            }

            for (int i = 0; i < tupleParts.Length; i++)
            {
                string tuplePart = tupleParts[i].Trim();

                (string argTemplateName, string argTemplateContent) = Unwrap(tuplePart);
                string[] argTupleParts = Parser.Split(argTemplateContent, ",");
                TypeDefinition paramType;

                // Note: First argument on the template is usually the index, we don't need it
                // // (assuming that it matches the parameter order).
                switch (argTemplateName)
                {
                    case "nn::sf::cmif::detail::BufferArgumentInfo":
                        funcParams[i].CommandArgType = CommandArgType.Buffer;
                        funcParams[i].BufferFlags = (HipcBufferFlags)ParseUnsignedIntegerNumber(argTupleParts[1]);
                        funcParams[i].BufferFixedSize = (ushort)ParseUnsignedIntegerNumber(argTupleParts[2]);
                        if (funcParams[i].IsCustomType)
                        {
                            materializer.AddUnmaterialized(new TypeDefinition(TypeKind.Structure, funcParams[i].TypeName));
                        }
                        if (materializer.TryGetExistingType(funcParams[i].TypeName, out paramType))
                        {
                            paramType.StructSize = funcParams[i].BufferFixedSize;
                            paramType.AddImport("System.Runtime.InteropServices");
                        }
                        break;
                    case "nn::sf::cmif::detail::InObjectArgumentInfo":
                    case "nn::sf::cmif::detail::OutObjectArgumentInfo":
                        funcParams[i].CommandArgType = CommandArgType.Object;
                        break;
                    case "nn::sf::cmif::detail::InHandleArgumentInfo":
                    case "nn::sf::cmif::detail::OutHandleArgumentInfo":
                        ulong copyOrMove = ParseUnsignedIntegerNumber(argTupleParts[1]); // Not sure if this is correct...
                        funcParams[i].CommandArgType = copyOrMove == 1 ? CommandArgType.CopyHandle : CommandArgType.MoveHandle;
                        break;
                    case "nn::sf::cmif::detail::InRawArgumentInfo":
                    case "nn::sf::cmif::detail::OutRawArgumentInfo":
                        if (funcParams[i].IsCustomType)
                        {
                            materializer.AddUnmaterialized(new TypeDefinition(TypeKind.Structure, funcParams[i].TypeName));
                        }
                        if (materializer.TryGetExistingType(funcParams[i].TypeName, out paramType))
                        {
                            paramType.StructSize = (int)ParseUnsignedIntegerNumber(argTupleParts[0]);
                            paramType.StructAlignment = (int)ParseUnsignedIntegerNumber(argTupleParts[1]);
                            paramType.AddImport("System.Runtime.InteropServices");
                            // Third argument is likely the offset.
                        }
                        break;
                }
            }
        }

        private static ulong ParseUnsignedIntegerNumber(string value)
        {
            return ulong.Parse(value.Trim().Replace("ul", string.Empty));
        }

        private static (string, string) UnwrapAt(string wrapped, int index)
        {
            (string name, string content) = Unwrap(wrapped);
            string[] unwrappedParts = Parser.Split(content, ",");

            if ((uint)index >= (uint)unwrappedParts.Length)
            {
                return (string.Empty, string.Empty);
            }

            return (name, unwrappedParts[index].Trim());
        }

        private static (string, string) UnwrapSingle(string wrapped)
        {
            (string name, string content) = Unwrap(wrapped);
            string[] unwrappedParts = Parser.Split(content, ",");

            // When BitFlagSet is used, the actual type is the second template argument, not the first one.
            if (name == "nn::util::BitFlagSet" && unwrappedParts.Length >= 2)
            {
                return (name, unwrappedParts[1].Trim());
            }

            return (name, unwrappedParts[0].Trim());
        }

        private static (string, string) Unwrap(string wrapped)
        {
            int startIndex = wrapped.IndexOf('<');
            if (startIndex < 0)
            {
                return (string.Empty, wrapped);
            }

            int endIndex = wrapped.LastIndexOf('>');
            if (endIndex < 0)
            {
                return (string.Empty, wrapped);
            }

            return (wrapped.Substring(0, startIndex), wrapped.Substring(startIndex + 1, endIndex - (startIndex + 1)));
        }
    }
}
