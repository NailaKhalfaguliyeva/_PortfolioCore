using _PortfolioCore.Context;
using Microsoft.AspNetCore.Mvc;

namespace _PortfolioCore.ViewComponents
{
    public class _DefaultLocationComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
    }
}
