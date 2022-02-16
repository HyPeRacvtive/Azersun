using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class SocialMedia
    {
        [Key]
        public int Id { get; set; }
        public string FaceBook { get; set; }
        public string Instagram { get; set; }
        public string Youtube { get; set; }
    }
}
