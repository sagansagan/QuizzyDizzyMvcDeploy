using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using QuizzyDizzyMvcDeploy.Models;
using System.Diagnostics;

namespace QuizzyDizzyMvcDeploy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var myText = _configuration["MySettings:MyTextVariable"] ?? "This text is local";
            ViewBag.MyText = myText;
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
