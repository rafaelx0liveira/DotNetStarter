namespace DotNetStarter.Core.Entities;

public class FolderStructure
{
    public string? Name { get; set; }
    public List<FolderStructure>? SubFolders { get; set; }
}
