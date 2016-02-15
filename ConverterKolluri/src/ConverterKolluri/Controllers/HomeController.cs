using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ConverterKolluri.Models;

namespace ConverterKolluri.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Converter App by Kolluri";
            ViewData["Result"] = "";

            Converter converter = new Converter();
            return View(converter);
        }

        public IActionResult Convert(Converter converter)
        {
            if (ModelState.IsValid)
            {
                ViewData["Title"] = "Converted by Kolluri";
                ViewData["Result"] = "Temperature in C = " +
                    (int)((converter.Temperature_F - 32) * 5.0 / 9.0);
            }
            return View("Index", converter);
        }

    }
}
