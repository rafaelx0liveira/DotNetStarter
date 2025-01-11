using DotNetStarter.Templates;

namespace DotNetStarter.Core.ProjectGenerator
{
    public class ProjectGenerator
    {
        public static void CreateProject(string architecture, string outputPath)
        {
            string templatePath = TemplateLoader.GetTemplatePath(architecture);

            if (!Directory.Exists(templatePath))
            {
                throw new DirectoryNotFoundException($"Template '{architecture}' not found at '{templatePath}'.");
            }

            // Define o caminho absoluto para o diretório de saída
            string destinationPath = Directory.GetCurrentDirectory();

            if (!outputPath.Equals("."))
            {
                if (string.IsNullOrWhiteSpace(outputPath) || !Path.IsPathRooted(outputPath))
                {
                    throw new DirectoryNotFoundException($"Output directory '{outputPath}' was not found.");
                }

                destinationPath = Path.GetFullPath(outputPath);
            }

            // Cria o diretório de destino, se não existir
            Directory.CreateDirectory(destinationPath);

            // Copia os arquivos do template
            foreach (var file in Directory.GetFiles(templatePath, "*.*", SearchOption.AllDirectories))
            {
                var content = File.ReadAllText(file);
                var relativePath = Path.GetRelativePath(templatePath, file);
                var outputFile = Path.Combine(destinationPath, relativePath);
                var dirName = Path.GetDirectoryName(outputFile);

                if(dirName == null)
                {
                    throw new DirectoryNotFoundException($"Directory name {dirName} was not found.");
                }

                // Garante que o diretório de destino do arquivo existe
                Directory.CreateDirectory(dirName);

                // Grava o arquivo no local de destino
                File.WriteAllText(outputFile, content);
            }
        }
    }
}
