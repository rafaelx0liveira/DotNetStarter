using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetStarter.Core.Architectures
{
    public static class Architectures
    {
        public static string[] AvailableArchitectures => [
            "clean",
            "cqrs",
            "ddd",
            "hexagonal",
            "microservice",
            "onion"
        ];
    }
}
