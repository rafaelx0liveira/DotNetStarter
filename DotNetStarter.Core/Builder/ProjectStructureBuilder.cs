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

        public void CreateFolders(string projectPath, string[] folders)
        {
            foreach (var folder in folders)
            {
                string folderPath = Path.Combine(projectPath, folder);
                Directory.CreateDirectory(folderPath);
            }
        }

        public void AddFoldersToCsproj(string csprojPath, string[] folders)
        {
            var csprojContent = File.ReadAllText(csprojPath);

            var folderReferences = string.Join(Environment.NewLine, folders.Select(folder =>
                $"    <Folder Include=\"{folder}\\\" />"));

            csprojContent = csprojContent.Replace("</Project>", $@"
  <ItemGroup>
{folderReferences}
  </ItemGroup>
</Project>");

            File.WriteAllText(csprojPath, csprojContent);
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
