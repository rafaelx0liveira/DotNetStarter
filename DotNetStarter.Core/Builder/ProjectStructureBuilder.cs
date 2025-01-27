using DotNetStarter.Core.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.Core.Builder
{
    public class ProjectStructureBuilder
    {
        public void CreateSolution(string solutionName, string outputPath)
        {
            RunDotNetCommand($"new sln -n {solutionName} -o \"{outputPath}\"");
        }

        public void AddProjectToSolution(string solutionPath, string projectPath)
        {
            RunDotNetCommand($"sln \"{solutionPath}\" add \"{projectPath}\"");
        }

        public void CreateClassLibraryProject(string projectName, string projectPath)
        {
            RunDotNetCommand($"new classlib -n {projectName} -o \"{projectPath}\"");
        }

        public void AddFoldersToCsproj(string csprojPath, FolderStructure folderStructure)
        {
            // Ler o conteúdo atual do arquivo .csproj
            var csprojContent = File.ReadAllText(csprojPath);

            // Gerar referências de pastas recursivamente
            var folderReferences = GenerateFolderReferences(folderStructure);

            // Inserir as referências de pastas no arquivo .csproj antes do fechamento da tag </Project>
            if (!csprojContent.Contains("<ItemGroup>"))
            {
                // Criar um novo ItemGroup se não existir
                csprojContent = csprojContent.Replace("</Project>", $@"
  <ItemGroup>
{folderReferences}
  </ItemGroup>
</Project>");
            }
            else
            {
                // Adicionar ao ItemGroup existente
                int itemGroupIndex = csprojContent.IndexOf("</ItemGroup>");
                csprojContent = csprojContent.Insert(itemGroupIndex, $"\n{folderReferences}");
            }

            // Escrever as alterações de volta no arquivo .csproj
            File.WriteAllText(csprojPath, csprojContent);
        }

        private string GenerateFolderReferences(FolderStructure folderStructure, string parentPath = "")
        {
            // Usar apenas o nome da pasta, ignorando o caminho do pai
            var folderReference = $"    <Folder Include=\"{folderStructure.Name}\\\" />";

            // Processar subpastas recursivamente
            var subFolderReferences = folderStructure.SubFolders != null
                ? folderStructure.SubFolders
                    .Select(subFolder => GenerateFolderReferences(subFolder)) // Não concatenar caminho do pai
                    .ToList()
                : new List<string>();

            // Combinar a referência da pasta atual com as referências das subpastas
            return string.Join(Environment.NewLine, new[] { folderReference }.Concat(subFolderReferences));
        }

        private void RunDotNetCommand(string arguments)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                string error = process.StandardError.ReadToEnd();
                throw new Exception($"Erro ao executar comando dotnet: {error}");
            }
        }
    }
}
