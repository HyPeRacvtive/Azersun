using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace Web.UI.ViewComponents.Admin
{
    public class Weather : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string api = "5c4dc92acf3a2e1cb22a7542b3fc2e03";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=adana&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument doc = XDocument.Load(connection);
            ViewBag.Temperature = doc.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.City = doc.Descendants("city").ElementAt(0).Attribute("name").Value;
            ViewBag.Cloud = doc.Descendants("clouds").ElementAt(0).Attribute("name").Value;
            ViewBag.icon = doc.Descendants("weather").ElementAt(0).Attribute("icon").Value;
            return View();
        }
    }
}
