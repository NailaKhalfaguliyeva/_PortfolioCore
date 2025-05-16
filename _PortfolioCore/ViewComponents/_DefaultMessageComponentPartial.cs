using _PortfolioCore.Context;
using _PortfolioCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _PortfolioCore.ViewComponents
{
    public class _DefaultMessageComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            return View(new Message());
        }
    }
}
