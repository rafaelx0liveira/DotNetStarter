using DotNetStarter.Core.Factories;
using DotNetStarter.Core.Builder;
using DotNetStarter.Core.Entities;

namespace DotNetStarter.Core.Services
{
    public class ProjectGenerator (
            ProjectArchitectureFactoryCreator projectArchitectureFactoryCreator,
            ProjectStructureBuilder structureBuilder
        )
    {

        private readonly ProjectArchitectureFactoryCreator _factoryCreator = projectArchitectureFactoryCreator;
        private readonly ProjectStructureBuilder _builder = structureBuilder;

        public void CreateProject(string projectName, string architecture, string outputPath)
        {
            // Obter a arquitetura específica através da factory
            var projectArchitecture = _factoryCreator.Create(architecture);

            // Obter a estrutura hierárquica de pastas
            var structure = projectArchitecture.GetStructure();

            // Criar a solução principal
            string solutionPath = Path.Combine(outputPath, $"{projectName}.sln");
            _builder.CreateSolution(projectName, outputPath);

            // Iterar pelas camadas (ex.: API, Core, Infrastructure, etc.)
            foreach (var layer in structure)
            {
                string layerName = $"{projectName}.{layer.Key}";
                string layerPath = Path.Combine(outputPath, layerName);

                // Criar o projeto principal da camada (ex.: API, Core.Domain, etc.)
                _builder.CreateClassLibraryProject(layerName, layerPath);

                // Criar as pastas recursivamente dentro da camada
                CreateFoldersRecursively(layerPath, layer.Value);

                // Atualizar o arquivo .csproj com as pastas criadas
                string csprojPath = Path.Combine(layerPath, $"{layerName}.csproj");
                //_builder.AddFoldersToCsproj(csprojPath, layer.Value);

                // Adicionar o projeto à solução principal
                _builder.AddProjectToSolution(solutionPath, csprojPath);
            }
        }

        /// <summary>
        /// Método recursivo para criar pastas com base na estrutura hierárquica.
        /// </summary>
        private void CreateFoldersRecursively(string basePath, FolderStructure folderStructure, bool isRoot = true)
        {
            // Determinar o caminho da pasta atual
            string currentPath = isRoot ? basePath : Path.Combine(basePath, folderStructure.Name);

            // Criar a pasta atual apenas se não for a raiz
            if (!isRoot)
            {
                Directory.CreateDirectory(currentPath);
            }

            //Adicionar um arquivo.gitkeep em todas as pastas, inclusive as vazias
            string placeholderPath = Path.Combine(currentPath, ".gitkeep");
            if (!File.Exists(placeholderPath))
            {
                File.WriteAllText(placeholderPath, string.Empty);
            }

            // Criar subpastas recursivamente
            if (folderStructure.SubFolders != null && folderStructure.SubFolders.Any())
            {
                foreach (var subFolder in folderStructure.SubFolders)
                {
                    CreateFoldersRecursively(currentPath, subFolder, false);
                }
            }
        }
    }
}
