using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TransactionScript.Domain;
using TransactionScript.Endpoint.MVC.Models;

namespace TransactionScript.Endpoint.MVC.Controllers
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

        public IActionResult RegisterPerson(string firstName, string lastName)
        {
            new PersonManager().RegisterPerson(firstName, lastName);
            return Ok();
        }
    }
}