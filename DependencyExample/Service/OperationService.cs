using DependencyExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyExample.Service
{
    public class OperationService
    {
        public OperationService(IOperationTransient transientOperation, 
            IOperationScoped scopedOperation, 
            IOperationSingleton singletonOperation)
        {
            TransientOperation = transientOperation;
            ScopedOperation = scopedOperation;
            SingletonOperation = singletonOperation;
        }

        public IOperationTransient TransientOperation { get; }
        public IOperationScoped ScopedOperation { get; }
        public IOperationSingleton SingletonOperation { get; }
    }


}
