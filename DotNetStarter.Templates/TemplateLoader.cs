using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.Templates
{
    public static class TemplateLoader
    {
        public static string GetTemplateFile(string templateName, string relativePath)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourcePath = $"DotNetStarter.Templates.{templateName}.{relativePath.Replace("\\", ".")}";

            using var stream = assembly.GetManifestResourceStream(resourcePath);

            if (stream == null) throw new FileNotFoundException($"Template file not found: {resourcePath}");

            using var reader = new StreamReader(stream);

            return reader.ReadToEnd();
        }
    }
}
