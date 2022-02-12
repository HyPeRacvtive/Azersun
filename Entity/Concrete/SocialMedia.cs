using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class SocialMedia
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
    }
}
