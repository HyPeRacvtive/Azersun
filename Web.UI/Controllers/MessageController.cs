using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EFCore;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.UI.Controllers
{
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EFMessageRepository());
        public IActionResult Index()
        {
            var values = mm.GetList();
            return View(values);
        }

        public IActionResult Detail(int id)
        {
            DataContext context = new DataContext();
            Messages messages = context.Messages.Find(id);
            if (!messages.IsRead)
            {
                messages.IsRead = true;
            }
            context.SaveChanges();
            var values = mm.GetById(id);
            return View(values);
        }
        public IActionResult Delete(int id)
        {
            var values = mm.GetById(id);
            mm.Delete(values);
            return RedirectToAction("Index");
        }
    }
}
