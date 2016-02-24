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
        
           // ViewData["Message"] = "Your application description page.";


            return View();
        }

        public IActionResult Contact()
        {

            //ViewData["Message"] = "Your contact page.";

            ViewData["Message"] = "Edit Team01  contact details.";


            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult schedulee()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
