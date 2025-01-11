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

            // Sets the absolute path to the output directory
            string destinationPath = Directory.GetCurrentDirectory();

            if (!outputPath.Equals("."))
            {
                if (string.IsNullOrWhiteSpace(outputPath) || !Path.IsPathRooted(outputPath))
                {
                    throw new DirectoryNotFoundException($"Output directory '{outputPath}' was not found.");
                }

                destinationPath = Path.GetFullPath(outputPath);
            }

            // Creates the destination directory if it does not exist
            Directory.CreateDirectory(destinationPath);

            // Copy the template files
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

                // Ensures that the file destination directory exists
                Directory.CreateDirectory(dirName);

                // Writes the file to the destination location
                File.WriteAllText(outputFile, content);
            }
        }
    }
}
