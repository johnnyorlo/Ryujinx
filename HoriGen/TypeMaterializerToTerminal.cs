using System;
using System.IO;

namespace HoriGen
{
    internal class TypeMaterializerToTerminal : TypeMaterializer
    {
        public TypeMaterializerToTerminal() : base(string.Empty)
        {
        }

        protected override void MaterializeImpl(string path, string fileName, string code)
        {
            Console.WriteLine($"Output for {Path.Combine(path, fileName)}:");
            Console.WriteLine();
            Console.WriteLine(code);
        }
    }
}
