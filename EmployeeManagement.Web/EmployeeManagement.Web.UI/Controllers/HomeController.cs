using EmployeeManagement.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger,
            IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            // Get the value from appsettings
          
            string baseUrl = _configuration.GetValue<string>("EmployeeManagementAPIBaseURL");

            // Set the value in ViewBag
            ViewBag.EmplyeeManagementAPIBaseURL = baseUrl;

            EmployeeManager employeeManager = new EmployeeManager();
            return View(employeeManager);
        }

        public IActionResult Employees()
        {

            EmployeeManager employeeManager = new EmployeeManager();
            return View(employeeManager);
        }

        public IActionResult Managers()
        {

            EmployeeManager employeeManager = new EmployeeManager();
            return View(employeeManager);
        }

 

        public IActionResult About()
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
