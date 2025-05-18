using _PortfolioCore.Context;
using _PortfolioCore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _PortfolioCore.Controllers
{
    public class MessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult MessageList()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {

            message.SendDate = DateTime.Now;
            message.IsRead = false;

            context.Messages.Add(message);
            context.SaveChanges();

            TempData["Success"] = "Your message has been sent successfully.!";
            return RedirectToAction("SendMessage");
        }

        public IActionResult MessageDetail(int id)
        {  
            var value = context.Messages.Find(id);
            if (!value.IsRead)
            {
                value.IsRead = true;
                context.SaveChanges();
            }
            return View(value);
        }
        public IActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);
            context.Messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("MessageList");
        }

        [HttpGet]
        public IActionResult UpdateMessage(int id)
        {
            var value = context.Messages.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateMessage(Message message)
        {
            context.Messages.Update(message);
            context.SaveChanges();
            return RedirectToAction("MessageList");
        }



        [HttpPost]
        public IActionResult ChangeReadStatus(int id)
        {
            var message = context.Messages.Find(id);
            if (message != null)
            {
                message.IsRead = !message.IsRead;
                context.SaveChanges();
            }
            return RedirectToAction("MessageDetail", new { id = id });
        }

    }
}
