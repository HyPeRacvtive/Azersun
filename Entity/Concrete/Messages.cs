using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Messages
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public bool IsRead { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string IpAdress { get; set; }
    }
}
