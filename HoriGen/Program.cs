using ARMeilleure.Memory;
using Ryujinx.HLE.HOS.Diagnostics.Demangler;
using System;
using System.Linq;

namespace HoriGen
{
    internal class Program
    {
        private const string NnSfSyncPrefix = "_nn_sf_sync_";

        static void Main(string[] args)
        {
            if (args.Length < 1 || args.Length > 2)
            {
                Console.WriteLine("Usage:");
                Console.WriteLine("HoriGen.exe sdk");
                Console.WriteLine("HoriGen.exe sdk C:\\Path\\To\\Output\\Folder");
                Console.WriteLine("The sdk file should be a NSO");

                return;
            }

            var nso = new NsoExecutable(args[0]);
            var image = Mod0Loader.Load(nso.Program, nso.TextOffset, nso.TextSize);

            var mm = new SimpleMemoryManager(nso.Program);

            ProgramAnalysis.Relocate(mm, image);

            TypeMaterializer materializer = args.Length > 1
                ? new TypeMaterializerToFile(args[1])
                : new TypeMaterializerToTerminal();

            foreach (var sym in image.Symbols.OrderBy(x => x.Value))
            {
                string demangled = Demangler.Parse(sym.Name);

                var funcInfo = FunctionSignatureParser.Parse(demangled);

                if (funcInfo.Name != null && funcInfo.Name.StartsWith(NnSfSyncPrefix))
                {
                    string interfaceName = ExtractInterfaceNameFromTemplate(funcInfo.ContainingType);
                    string csInterfaceName = NameConverter.ConvertCppToCSharpNamespace(interfaceName);

                    TypeDefinition typeDef = materializer.GetOrAdd(csInterfaceName, () =>
                    {
                        var typeDef = new TypeDefinition(TypeKind.Interface, csInterfaceName);
                        typeDef.AddImport("Ryujinx.Horizon.Common"); // Result type is located here.
                        typeDef.AddImport("Ryujinx.Horizon.Sdk.Sf"); // IServiceObject
                        typeDef.AddImplement("Ryujinx.Horizon.Sdk.Sf.IServiceObject");
                        return typeDef;
                    });

                    string funcName = funcInfo.Name.Substring(NnSfSyncPrefix.Length);
                    MethodParameter[] funcParams = new MethodParameter[funcInfo.ParameterTypes.Length];

                    for (int i = 0; i < funcParams.Length; i++)
                    {
                        funcParams[i] = FunctionSignatureParser.ParseParameter(materializer, typeDef, funcInfo.ParameterTypes[i], i);
                    }

                    (ulong processFuncAddress, int commandId) = ProgramAnalysis.FindProcessAddressAndCommandId(mm, sym.Value);

                    if (processFuncAddress != 0)
                    {
                        processFuncAddress = ProgramAnalysis.GetTargetAddressFromThunk(mm, processFuncAddress);
                    }

                    if (processFuncAddress != 0 && image.SymbolsByAddress.TryGetValue(processFuncAddress, out var processFuncSym))
                    {
                        string processFuncName = Demangler.Parse(processFuncSym.Name);
                        FunctionSignatureParser.ParseAdditionalParameterInfo(materializer, processFuncName, ref funcParams);
                    }

                    typeDef.AddMember(new MethodDefinition(funcName, funcParams, commandId));
                }
            }

            var allInterfaces = materializer.GetAll().Where(x => x.Kind == TypeKind.Interface).ToArray();

            foreach (var typeDef in allInterfaces)
            {
                (var namespaceName, var typeName) = TypeCodeGenerator.SplitTypeAndNamespace(typeDef.Name);

                if (!string.IsNullOrEmpty(namespaceName) && NameConverter.IsInterfaceName(typeName) && typeDef.Kind == TypeKind.Interface)
                {
                    var classTypeDef = new TypeDefinition(TypeKind.Class, namespaceName + '.' + typeName.Substring(1));
                    classTypeDef.AddMembers(typeDef.GetMembers());
                    classTypeDef.AddImports(typeDef.GetImports());

                    if (typeDef.GetMembers().Any(x => x is MethodDefinition methodDef && methodDef.Parameters.Any(x => x.CommandArgType == CommandArgType.Buffer)))
                    {
                        classTypeDef.AddImport("Ryujinx.Horizon.Sdk.Sf.Hipc"); // HipcBufferFlags
                    }

                    classTypeDef.AddImplement(typeDef.Name);

                    materializer.AddUnmaterialized(classTypeDef);
                }
                
            }

            materializer.MaterializeAll();

            Console.WriteLine("Done.");
        }

        private static string ExtractInterfaceNameFromTemplate(string template)
        {
            int startIndex = template.IndexOf('<') + 1;

            if (startIndex == 0)
            {
                return "IUnknown";
            }

            int endIndex = template.IndexOfAny(new char[] { ',', '>' }, startIndex);

            if (endIndex < 0)
            {
                endIndex = template.Length;
            }

            return template.Substring(startIndex, endIndex - startIndex);
        }
    }
}