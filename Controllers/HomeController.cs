/******************************************************************************************************************************
 * Student Name: Dakota Parrish
 * Project Name: NETD3202 Lab 5
 * Course Code: NETD3202
 * Date: December 7, 2020
 * Purpose: The purpose of this page is to be the controller for the home views. It controls the use of views of the index and
 * privacy pages.
 * ***************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NETD3202Lab5_1.Models;

namespace NETD3202Lab5_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
