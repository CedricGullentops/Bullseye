﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FysicsLeague.Models;

namespace FysicsLeague.Controllers
{
    public class DewetvancoulombController : Controller
    {
        public IActionResult Theorie()
        {
            return View();
        }

        public IActionResult Grootheden()
        {
            return View();
        }

        public IActionResult Krachtvectoren()
        {
            return View();
        }

        public IActionResult Formule()
        {
            return View();
        }

        /*public IActionResult CheckNumericalAnswer(float answer)
        {
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
