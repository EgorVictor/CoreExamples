using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DependencyExample.Pages
{
    public class AboutModel : PageModel
    {
        private readonly ILogger logger;

        public AboutModel(ILogger logger)
        {
            this.logger = logger;
        }

        public string Message { get; set; }

        public void OnGet()
        {
            Message = $"About page visited at {DateTime.UtcNow.ToLongTimeString()}";
            logger.LogInformation(Message);
        }
    }
}
