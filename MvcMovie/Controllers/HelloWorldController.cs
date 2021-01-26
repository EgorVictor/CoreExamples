using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
       /* //Get:/HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        }

        // GET: /HelloWorld/Welcome/ 
        public string Welcome(string name,int numTimes=1)
        {
            return HtmlEncoder.Default.Encode($"Hello{name},NumTimes is:{numTimes}");
        }*/

       public IActionResult Index()
       {
           return View();
       }
    }
}
