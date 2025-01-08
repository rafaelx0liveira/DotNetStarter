namespace DotNetStarter.Core
{
    public class ProjectGenerator
    {
        public static void CreateProject(string architecture, string projectName, string outputPath)
        {
            string templatePath = $"Templates/{architecture}";
            string destinationPath = Path.Combine(outputPath, architecture);

            if (!Directory.Exists(destinationPath))
            {
                throw new ArgumentException($"Template {architecture} not found.");
            }

            Directory.CreateDirectory(destinationPath);

            foreach(var file in Directory.GetFiles(templatePath, "*.*", SearchOption.AllDirectories))
            {
                var content = File.ReadAllText(file)
                    .Replace("{{ProjectName}}", projectName);

                var relativePath = file.Substring(templatePath.Length + 1);
                var outputFile = Path.Combine(destinationPath, relativePath);

                Directory.CreateDirectory(Path.GetDirectoryName(outputFile));
                File.WriteAllText(outputFile, content);
            }

        }
    }
}
