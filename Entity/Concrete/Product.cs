using System;

namespace Entity.Concrete
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Stock { get; set; }
        public bool Statu { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
