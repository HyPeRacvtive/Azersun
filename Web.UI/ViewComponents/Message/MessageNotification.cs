using Business.Concrete;
using DataAccess.Concrete.EFCore;
using Microsoft.AspNetCore.Mvc;

namespace Web.UI.ViewComponents.Message
{
    public class MessageNotification : ViewComponent
    {
        MessageManager am = new MessageManager(new EFMessageRepository());
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }

}
