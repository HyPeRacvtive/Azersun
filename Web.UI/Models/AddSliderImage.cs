using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.Models
{
    public class AddSliderImage
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public IFormFile Image { get; set; }
        public bool Statu { get; set; }
    }
}
