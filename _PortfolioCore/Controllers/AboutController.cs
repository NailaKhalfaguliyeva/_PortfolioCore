using _PortfolioCore.Context;
using _PortfolioCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _PortfolioCore.Controllers
{
    public class AboutController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult AboutList()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(About about, IFormFile image)
        {
            if (image != null && image.Length > 0)
            {
                var extension = Path.GetExtension(image.FileName);
                var fileName = Guid.NewGuid().ToString() + extension;
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/about", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }

                about.ImageUrl = "/images/about/" + fileName;
            }

            context.Abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about, IFormFile image)
        {
            var existing = context.Abouts.Find(about.AboutId);
            if (existing == null)
                return NotFound();


            existing.JobTitle = about.JobTitle;
            existing.AboutDescription = about.AboutDescription;

            if (image != null && image.Length > 0)
            {
                var extension = Path.GetExtension(image.FileName);
                var fileName = Guid.NewGuid().ToString() + extension;
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/about", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }

                existing.ImageUrl = "/images/about/" + fileName;
            }

            context.Abouts.Update(existing);
            context.SaveChanges();

            return RedirectToAction("AboutList");
        }

        public IActionResult DeleteAbout(int id)
        {
            var value = context.Abouts.Find(id);
            context.Abouts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}
