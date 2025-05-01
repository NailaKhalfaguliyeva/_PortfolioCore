using Microsoft.AspNetCore.Mvc;

namespace _PortfolioCore.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
