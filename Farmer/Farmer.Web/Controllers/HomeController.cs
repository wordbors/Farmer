﻿using Farmer.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Farmer.Services;

namespace Farmer.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
