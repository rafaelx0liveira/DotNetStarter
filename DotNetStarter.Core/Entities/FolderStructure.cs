using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.Core.Entities
{
    public class FolderStructure
    {
        public string? Name { get; set; }
        public List<FolderStructure>? SubFolders { get; set; }
    }
}
