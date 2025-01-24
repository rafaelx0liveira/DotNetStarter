using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.Core.Interfaces
{
    public interface IArchitectureFactory
    {
        Dictionary<string, string[]> GetStructure();
    }
}
