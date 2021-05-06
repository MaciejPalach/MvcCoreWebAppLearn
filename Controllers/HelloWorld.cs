using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace MvcCoreWebApp.Controllers
{
    public class HelloWorld : Controller
    {
        public string Index()
        {
            return "Default Action";
        }

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            //return "Welcome Action";
        }
    }
}
