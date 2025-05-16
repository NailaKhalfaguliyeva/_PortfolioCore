using _PortfolioCore.Context;
using Microsoft.AspNetCore.Mvc;

namespace _PortfolioCore.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v0 = "Statistics";
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Skills.Sum(x => x.SkillValue);
            ViewBag.v3 = context.Skills.Where(x => x.SkillValue >= 70).Count();
            ViewBag.v4 = context.Skills.Average(x => x.SkillValue);
            ViewBag.v5 = context.Experiences.Count();
            ViewBag.v6 = context.Experiences.Where(x => x.SubTitle == "Developer").Count();
            ViewBag.v7 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v8 = context.Services.Count();
            ViewBag.v9 = context.Testimonials.Count();
            ViewBag.v10 = context.Categories.Count();
            return View();
        }
    }
}
