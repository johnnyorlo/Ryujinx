using System;
using System.Collections.Generic;
using System.IO;

namespace HoriGen
{
    internal abstract class TypeMaterializer
    {
        private readonly string _basePath;
        private readonly Queue<TypeDefinition> _unmaterializedQueue;
        private readonly Dictionary<string, TypeDefinition> _unmaterializedTypeNames;
        private readonly HashSet<string> _materializedTypeNames;

        public TypeMaterializer(string basePath)
        {
            _basePath = basePath;
            _unmaterializedQueue= new Queue<TypeDefinition>();
            _unmaterializedTypeNames= new Dictionary<string, TypeDefinition>();
            _materializedTypeNames= new HashSet<string>();
        }

        public void AddUnmaterialized(TypeDefinition typeDefinition)
        {
            if (_unmaterializedTypeNames.TryAdd(typeDefinition.Name, typeDefinition) &&
                !_materializedTypeNames.Contains(typeDefinition.Name))
            {
                _unmaterializedQueue.Enqueue(typeDefinition);
            }
        }

        public TypeDefinition GetOrAdd(string name, Func<TypeDefinition> factory)
        {
            if (!_unmaterializedTypeNames.TryGetValue(name, out var typeDef))
            {
                typeDef = factory();
                AddUnmaterialized(typeDef);
            }

            return typeDef;
        }

        public bool TryGetExistingType(string name, out TypeDefinition typeDefinition)
        {
            return _unmaterializedTypeNames.TryGetValue(name, out typeDefinition);
        }

        public void MaterializeAll()
        {
            while (_unmaterializedQueue.TryDequeue(out TypeDefinition typeDefinition))
            {
                _materializedTypeNames.Add(typeDefinition.Name);
                string code = TypeCodeGenerator.Generate(typeDefinition);

                (string namespaceName, string typeName) = TypeCodeGenerator.SplitTypeAndNamespace(typeDefinition.Name);
                string path = GetPathFromNamespace(_basePath, namespaceName);

                MaterializeImpl(path, Path.Combine(path, typeName + ".cs"), code);
            }
        }

        protected abstract void MaterializeImpl(string path, string fileName, string code);

        protected static string GetPathFromNamespace(string basePath, string namespaceName)
        {
            const string RootNamespace = "Ryujinx.Horizon";

            if (namespaceName.StartsWith(RootNamespace))
            {
                namespaceName = namespaceName.Substring(RootNamespace.Length);

                if (namespaceName.StartsWith('.'))
                {
                    namespaceName = namespaceName.Substring(1);
                }
            }

            string[] folders = namespaceName.Split('.');
            string fullPath = Path.Combine(basePath, RootNamespace, Path.Combine(folders));

            return fullPath;
        }

        public IEnumerable<TypeDefinition> GetAll()
        {
            return _unmaterializedTypeNames.Values;
        }
    }
}
