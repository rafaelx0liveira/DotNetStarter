using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.Templates
{
    public static class TemplateLoader
    {
        public static string GetTemplatePath(string templateName)
        {
            // Project base path
            var templatePath = Path.Combine(AppContext.BaseDirectory, $"{templateName}");

            // Checks if the template directory exists
            if (!Directory.Exists(templatePath))
            {
                throw new DirectoryNotFoundException($"Template '{templateName}' not found at '{templatePath}'.");
            }

            return templatePath;
        }
    }
}
