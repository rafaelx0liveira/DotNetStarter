namespace DotNetStarter.Core.Builder;

public class ProjectStructureBuilder
{
    private string _csprojPath = string.Empty;

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

    /// <summary>
    /// Cria as pastas e atualiza o arquivo .csproj com as referências de pastas.
    /// </summary>
    public void CreateFoldersAndUpdateCsproj(string basePath, FolderStructure folderStructure, bool isRoot = true)
    {
        List<string> createdFolders = new();

        CreateFoldersRecursively(basePath, folderStructure, isRoot, createdFolders);
        UpdateCsprojFile(createdFolders);
    }

    /// <summary>
    /// Método recursivo para criar pastas com base na estrutura hierárquica.
    /// </summary>
    private void CreateFoldersRecursively(string basePath, FolderStructure folderStructure, bool isRoot, List<string> createdFolders)
    {
        // Determinar o caminho da pasta atual
        string currentPath = isRoot ? basePath : Path.Combine(basePath, folderStructure.Name);

        // Criar a pasta atual apenas se não for a raiz
        if (!isRoot)
        {
            Directory.CreateDirectory(currentPath);
            createdFolders.Add(currentPath);
        }

        if (isRoot)
        {
            var fileCsproj = $"{currentPath.Split("\\").Last()}.csproj";
            _csprojPath = Path.Combine(currentPath, fileCsproj);
        }

        // Criar subpastas recursivamente
        if (folderStructure.SubFolders != null && folderStructure.SubFolders.Any())
        {
            foreach (var subFolder in folderStructure.SubFolders)
            {
                CreateFoldersRecursively(currentPath, subFolder, false, createdFolders);
            }
        }
    }

    private void UpdateCsprojFile(List<string> folders)
    {
        const string tagItemGroup = "ItemGroup";
        const string tagFolder = "Folder";
        const string attributeInclude = "Include";

        if (!File.Exists(_csprojPath))
            throw new FileNotFoundException($"Arquivo de projeto não encontrado: {_csprojPath}");

        XDocument csprojXml = XDocument.Load(_csprojPath);
        XElement projectElement = csprojXml.Root;

        if (projectElement == null) return;

        // Adicionar as pastas dentro de um <ItemGroup>
        XElement itemGroup = projectElement.Elements(tagItemGroup).FirstOrDefault();

        if (itemGroup == null)
        {
            itemGroup = new XElement(tagItemGroup);
            projectElement.Add(itemGroup);
        }

        // Para cada pasta, adicionar um elemento <Folder> ao <ItemGroup>
        foreach (var folder in folders)
        {
            string relativePath = Path.GetRelativePath(Path.GetDirectoryName(_csprojPath), folder).Replace("\\", "/");

            if (!itemGroup.Elements(tagFolder).Any(e => e.Attribute(attributeInclude)?.Value == relativePath))
            {
                itemGroup.Add(new XElement(tagFolder, new XAttribute(attributeInclude, relativePath)));
            }
        }

        csprojXml.Save(_csprojPath);
    }
}
