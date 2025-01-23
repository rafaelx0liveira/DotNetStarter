using DotNetStarter.Templates;
using System.Diagnostics;

namespace DotNetStarter.Core.ProjectGenerator
{
    public class ProjectGenerator
    {
        public static void CreateProject(string projectName, string architecture, string outputPath)
        {
            // Define as estruturas baseadas na arquitetura
            var architectures = new Dictionary<string, Dictionary<string, string[]>>
            {
                {
                    "clean", new Dictionary<string, string[]>
                    {
                        { "Application", new[] { "DTOs", "Interfaces", "Services", "UseCases" } },
                        { "Domain", new[] { "Entities", "Interfaces", "ValueObjects" } },
                        { "Infrastructure", new[] { "Context", "Migrations", "Repositories" } },
                        { "CrossCutting", new[] { "DependencyInjection" } },
                        { "Tests", new[] { "UnitTests" } }
                    }
                },
                {
                    "ddd", new Dictionary<string, string[]>
                    {
                        { "Application", new[] { "Commands", "Queries", "Services" } },
                        { "Domain", new[] { "Aggregates", "Entities", "ValueObjects", "Events" } },
                        { "Infrastructure", new[] { "Persistence", "Repositories", "Services" } },
                        { "Tests", new[] { "UnitTests", "IntegrationTests" } }
                    }
                },
                {
                    "hexagonal", new Dictionary<string, string[]>
                    {
                        { "Adapters", new[] { "Inbound", "Outbound" } },
                        { "Application", new[] { "Services", "Interfaces" } },
                        { "Domain", new[] { "Entities", "ValueObjects", "Events" } },
                        { "Infrastructure", new[] { "Persistence", "Messaging" } },
                        { "Tests", new[] { "Adapters", "Application", "Domain" } }
                    }
                }
            };

            // Verifica se a arquitetura é suportada
            if (!architectures.ContainsKey(architecture.ToLower()))
            {
                throw new ArgumentException($"Arquitetura '{architecture}' não é suportada.");
            }

            // Obtém a estrutura para a arquitetura escolhida
            var layers = architectures[architecture.ToLower()];

            // Diretório base para o projeto
            string basePath = outputPath;

            foreach (var layer in layers)
            {
                // Nome do projeto
                string layerName = $"{projectName}.{layer.Key}";

                // Caminho completo para a camada
                string layerPath = Path.Combine(basePath, layerName);

                // Cria o projeto com o CLI do .NET
                Console.WriteLine($"Criando projeto {layerName}...");
                RunDotNetCommand($"new classlib -n {layerName} -o \"{layerPath}\"");

                // Adiciona as pastas específicas da camada
                foreach (var folder in layer.Value)
                {
                    string folderPath = Path.Combine(layerPath, folder);
                    Directory.CreateDirectory(folderPath);
                }
            }

            // Cria a solução principal
            string solutionPath = Path.Combine(outputPath, $"{projectName}.sln");
            RunDotNetCommand($"new sln -n {projectName} -o \"{outputPath}\"");

            // Adiciona todos os projetos à solução
            foreach (var layer in layers)
            {
                string layerName = $"{projectName}.{layer.Key}";
                string layerPath = Path.Combine(basePath, layerName);
                string csprojPath = Path.Combine(layerPath, $"{layerName}.csproj");

                // Lê o conteúdo do arquivo .csproj
                var csprojContent = File.ReadAllText(csprojPath);

                // Adiciona as pastas vazias como ItemGroup
                var folderReferences = string.Join(Environment.NewLine, layer.Value.Select(folder =>
                    $"    <Folder Include=\"{folder}\\\" />"));

                // Insere o ItemGroup no arquivo .csproj
                csprojContent = csprojContent.Replace("</Project>", $@"
                      <ItemGroup>
                    {folderReferences}
                      </ItemGroup>
                    </Project>");

                // Escreve de volta no arquivo .csproj
                File.WriteAllText(csprojPath, csprojContent);
            }

            // Adiciona todos os projetos à solução
            foreach (var layer in layers)
            {
                string layerName = $"{projectName}.{layer.Key}";
                string projectPath = Path.Combine(basePath, layerName, $"{layerName}.csproj");
                RunDotNetCommand($"sln \"{solutionPath}\" add \"{projectPath}\"");
            }

            Console.WriteLine("Estrutura criada com sucesso!");
        }

        // Método para executar comandos do .NET CLI
        private static void RunDotNetCommand(string arguments)
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
