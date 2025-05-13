using _PortfolioCore.Context;
using Microsoft.AspNetCore.Mvc;

namespace _PortfolioCore.ViewComponents
{
    public class _DefaultContactComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Contacts.ToList();
            return View(value);
        }
    }
}
