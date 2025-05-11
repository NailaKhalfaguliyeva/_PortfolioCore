using _PortfolioCore.Context;
using Microsoft.AspNetCore.Mvc;

namespace _PortfolioCore.ViewComponents
{
    public class _DefaultServiceComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Services.Take(6).ToList();
            return View(value);
        }
    }
}
