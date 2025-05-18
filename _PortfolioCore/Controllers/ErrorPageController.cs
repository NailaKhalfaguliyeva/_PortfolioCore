using Microsoft.AspNetCore.Mvc;

namespace _PortfolioCore.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Page404(int code)
        {
            return View();
        }
    }
}
