using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcCoreCrudDemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreCrudDemo.Controllers
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

        [HttpPost]
        public JsonResult AjaxMethod(PersonModel person)
        {
            person.DateTime = DateTime.Now.ToString();

            return Json(person);
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

        public IActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateStudent(StudentModel student)
        {
            if (!ModelState.IsValid) return BadRequest("Enter required fields");
            //Write your Insert code here;
            return this.Ok($"Form Data received!");
        }
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddStudent(StudentModel student)
        {
            if (!ModelState.IsValid) return BadRequest("Enter required fields");
            //Write your Insert code here;
            return this.Ok($"Form Data received!");
        }
    }
}
