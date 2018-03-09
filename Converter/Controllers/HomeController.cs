using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Converter.Models;

namespace Converter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Convert(Conv conv)
        {

            switch (conv.ToConvert)
            {
                case "mph to km/h":
                    conv.Result = conv.Cnum * 1.6;

                    break;

                case "km/h to mph":
                conv.Result = conv.Cnum / 1.6;
                    break;

                case "C to F":
                conv.Result = conv.Cnum *1.8 +32;
                    break;

                case "F to C":
                conv.Result = (conv.Cnum -32) /1.8;
                    break;
            }
            return View(conv);
        }

    }
}
