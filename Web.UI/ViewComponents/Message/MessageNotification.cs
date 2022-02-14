using Business.Concrete;
using DataAccess.Concrete.EFCore;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.UI.ViewComponents.Message
{
    public class MessageNotification : ViewComponent
    {
        MessageManager am = new MessageManager(new EFMessageRepository());
        public IViewComponentResult Invoke()
        {
            var values = am.GetList().OrderByDescending(x => x.CreateDate);
            return View(values);
        }
    }

}
