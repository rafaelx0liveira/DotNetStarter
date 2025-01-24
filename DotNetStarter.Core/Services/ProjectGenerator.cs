using DotNetStarter.Core.Factories;
using DotNetStarter.Core.Builder;

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
            var projectArchitecture = _factoryCreator.Create(architecture);

            var structure = projectArchitecture.GetStructure();

            // Cria a solução principal
            string solutionPath = Path.Combine(outputPath, $"{projectName}.sln");
            _builder.CreateSolution(projectName, outputPath);

            foreach(var layer in structure)
            {
                string layerName = $"{projectName}.{layer.Key}";
                string layerPath = Path.Combine(outputPath, layerName);

                // Cria o projeto e as pastas
                _builder.CreateClassLibraryProject(layerName, layerPath);
                _builder.CreateFolders(layerPath, layer.Value);

                // Atualiza o arquivo .csproj
                string csprojPath = Path.Combine(layerPath, $"{layerName}.csproj");
                _builder.AddFoldersToCsproj(csprojPath, layer.Value);

                // Adiciona o projeto à solução
                _builder.AddProjectToSolution(solutionPath, csprojPath);
            }
        }
    }
}
