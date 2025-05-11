using _PortfolioCore.Context;
using Microsoft.AspNetCore.Mvc;

namespace _PortfolioCore.ViewComponents
{
    public class _DefaultCategoryComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }
    }
}
