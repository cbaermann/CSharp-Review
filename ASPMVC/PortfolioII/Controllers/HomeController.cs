using Microsoft.AspNetCore.Mvc;

namespace PortfolioII
{
    public class HomeController : Controller
    {
        [HttpGet("/home")]

        public IActionResult Index()
        {
            return View("Index");
        }
        
        [HttpGet("/projects")]
        public IActionResult Projects()
        {
            return View("projects");
        }

        [HttpGet("/contact")]
        public IActionResult Contact()
        {
            return View("contact");
        }
    }
}