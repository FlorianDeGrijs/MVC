using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Form.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Verwerken(string Naam, int Geboortejaar)
        {
            if (Geboortejaar < 1998)
            {
                ViewData["Message"] = "Hartelijk dank meneer/mevrouw " + Naam;
            }
            else
            {
                ViewData["Message"] = "Helaas bent u nog te jong.";
            }

            return View();
        }
    }
}