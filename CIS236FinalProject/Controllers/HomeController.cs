﻿using CIS236FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CIS236FinalProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
