using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.Models
{
    public class AddVideoImage
    {
        public int Id { get; set; }
        public IFormFile Image { get; set; }
        public string Link { get; set; }
    }
}
