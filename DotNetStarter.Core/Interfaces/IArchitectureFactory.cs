namespace DotNetStarter.Core.Interfaces;

public interface IArchitectureFactory
{
    Dictionary<string, FolderStructure> GetStructure();
}
