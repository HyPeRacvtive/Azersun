using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
   public class Settings
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string ProjectText { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public string Map { get; set; }
    }
}
