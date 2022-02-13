using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Stock { get; set; }
        public bool Statu { get; set; } = true;
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
