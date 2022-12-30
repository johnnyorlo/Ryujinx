using System;
using System.IO;

namespace HoriGen
{
    internal class TypeMaterializerToFile : TypeMaterializer
    {
        public TypeMaterializerToFile(string basePath) : base(basePath)
        {
        }

        protected override void MaterializeImpl(string path, string fileName, string code)
        {
            string fullPath = Path.Combine(path, fileName);

            Console.WriteLine($"Writing {fullPath}...");

            Directory.CreateDirectory(path);
            File.WriteAllText(fullPath, code);
        }
    }
}
