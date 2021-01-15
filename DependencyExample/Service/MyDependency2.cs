using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyExample.Models.impl
{
    public class MyDependency2 : IMyDependency
    {
        private readonly ILogger<MyDependency2> logger;

        public MyDependency2(ILogger<MyDependency2> logger)
        {
            this.logger = logger;
        }

        public void WriteMessage(string message)
        {
            string str = $"MyDependency2.WriteMessage called. Message: {message}";
            logger.LogInformation(str);
        }
    }
}
