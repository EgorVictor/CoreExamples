using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyExample
{
    public interface IMyDependency
    {
        void WriteMessage(string message);
    }
}
