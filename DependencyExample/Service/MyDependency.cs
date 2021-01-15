using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyExample.Models.impl
{
    public class MyDependency : IMyDependency
    {
        private readonly ILogger<MyDependency> logger;

        public MyDependency(ILogger<MyDependency> logger)
        {
            this.logger = logger;
        }

        public void WriteMessage(string message)
        {
            logger.LogInformation($"MyDependency.WriteMessage called. Message: {message}");
        }
    }
}
