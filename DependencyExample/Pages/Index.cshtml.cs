using DependencyExample.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //private readonly IMyDependency myDependency;
        private readonly IOperationTransient operationTransient;
        private readonly IOperationScoped operationScoped;
        private readonly IOperationSingleton operationSingleton;

        public IndexModel(ILogger<IndexModel> logger, IOperationTransient operationTransient, IOperationScoped operationScoped, IOperationSingleton operationSingleton)
        {
            _logger = logger;
            this.operationTransient = operationTransient;
            this.operationScoped = operationScoped;
            this.operationSingleton = operationSingleton;
        }

        /*public IndexModel(IMyDependency myDependency, ILogger<IndexModel> logger)
        {
            this.myDependency = myDependency;
            _logger = logger;
        }*/

        public void OnGet()
        {
            _logger.LogInformation("Transient: " + operationTransient.OperationId);
            _logger.LogInformation("Scoped: " + operationScoped.OperationId);
            _logger.LogInformation("Singleton: " + operationSingleton.OperationId);
        }
    }
}
