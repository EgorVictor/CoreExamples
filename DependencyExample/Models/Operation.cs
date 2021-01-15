using DependencyExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyExample.Service
{
    public class Operation : IOperationTransient,
        IOperationScoped,
        IOperationSingleton
    {

        public Operation()
        {
            OperationId = Guid.NewGuid().ToString()[^4..];
        }

        public string OperationId { get; }
    }
}
