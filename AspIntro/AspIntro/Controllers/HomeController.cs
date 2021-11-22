using AspIntro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspIntro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Rasim";
            ViewData["Surname"] = "Quliyev";
            TempData["Address"] = "Baku";
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
