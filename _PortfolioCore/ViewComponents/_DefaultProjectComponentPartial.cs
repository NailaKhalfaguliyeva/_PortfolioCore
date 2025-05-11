using _PortfolioCore.Context;
using Microsoft.AspNetCore.Mvc;

namespace _PortfolioCore.ViewComponents
{
    public class _DefaultProjectComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
    }
}
