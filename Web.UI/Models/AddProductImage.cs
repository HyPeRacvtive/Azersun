using Microsoft.AspNetCore.Http;
using System;

namespace Web.UI.Models
{
    public class AddProductImage
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public IFormFile ProductImage { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Stock { get; set; }
        public bool Statu { get; set; } = true;
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
