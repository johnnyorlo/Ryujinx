using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoriGen
{
    static class NameConverter
    {
        public static string GetCSharpTypeName(string typeName, out bool isCustomType)
        {
            string? builtInType = typeName switch
            {
                "unsigned char" => "byte",
                "char" or "signed char" => "sbyte",
                "unsigned short" => "ushort",
                "short" or "signed short" => "short",
                "unsigned int" => "uint",
                "int" or "signed int" => "int",
                "unsigned long" => "ulong",
                "long" or "signed long" => "long",
                "float" => "float",
                "double" => "double",
                "bool" => "bool",
                "nn::sf::NativeHandle" => "int", // TODO: We should create our own handle type.
                "nn::sf::InBuffer" => "System.ReadOnlySpan<byte>",
                "nn::sf::OutBuffer" => "System.Span<byte>",
                _ => null
            };

            if (builtInType != null)
            {
                isCustomType = false;
                return builtInType;
            }

            isCustomType = true;
            return ConvertCppToCSharpNamespace(typeName);
        }

        public static string ConvertCppToCSharpNamespace(string cppNamespace)
        {
            string[] namespaceParts = Parser.Split(cppNamespace, "::");

            if (namespaceParts.Length == 0)
            {
                return string.Empty;
            }

            string[] outputParts = new string[namespaceParts.Length];

            for (int i = 0; i < namespaceParts.Length; i++)
            {
                string part = namespaceParts[i];

                if (i == 0 && (part == "nn" || part == "nns"))
                {
                    outputParts[i] = "Ryujinx.Horizon.Sdk";
                }
                else
                {
                    outputParts[i] = LowerToPascalCaseName(part);
                }
            }

            return string.Join('.', outputParts);
        }

        public static string LowerToPascalCaseName(string name)
        {
            string output = string.Empty;

            for (int i = 0; i < name.Length; i++)
            {
                output += i == 0
                    ? name[i].ToString().ToUpperInvariant()
                    : name[i].ToString();
            }

            return output;
        }

        public static bool IsInterfaceName(string name)
        {
            return name.Length >= 2 &&
                name[0] == 'I' &&
                char.IsUpper(name[1]);
        }
    }
}
