using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
    }
}
