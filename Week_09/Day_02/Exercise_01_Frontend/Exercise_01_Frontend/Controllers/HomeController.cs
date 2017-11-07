﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exercise_01_Frontend.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exercise_01_Frontend.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }
        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }
        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            return Json(new { welcome_message = "Oh, hi there " + name + ", my dear " + title + "!" });
        }

        [HttpGet]
        [Route("/appenda/{appendable}")]
        public IActionResult Appenda(string appendable)
        {
            return Json(new { appended = appendable + "a" });
        }
        
        [HttpPost]
        [Route("dountil/{what}")]
        public IActionResult Dountil(string what,[FromBody] DoUntil Number)
        {
            if (what == "sum" && Number == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            else if (what == "sum" && Number != null)
            {
                return Json(new { result = Number.Sum() });
            }
            else if (what == "factor" && Number == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            else if (what == "factor" && Number != null)
            {
                return Json(new { result = Number.Factor() });
            }
            return Json(new { error = "Please provide a number!" });
        }
    }
}
