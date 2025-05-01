using _PortfolioCore.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _PortfolioCore.ViewComponents
{
    public class _DefaultSocialMediaComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.SocialMedias.Where(x=>x.SocialMediaStatus==true).ToList();
            return View(values);
        }
    }
}
