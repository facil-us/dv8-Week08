using Lab_02_Registration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab_02_Registration.Controllers
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

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ProcessLogin(string Username, string Password)
        {
            ViewBag.Username = Username;
            ViewBag.Password = Password;
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult ProcessRegistration(string FirstName, string LastName, string Email, string Password)
        {
            ViewBag.FirstName = FirstName;
            ViewBag.LastName = LastName;
            ViewBag.Email = Email;
            ViewBag.Password = Password;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}