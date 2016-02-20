using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Team01_Project01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Edit Team01 Description here";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Edit Team01  contact details.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
