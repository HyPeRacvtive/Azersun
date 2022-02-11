using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Videos
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
    }
}
