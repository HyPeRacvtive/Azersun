using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Messages
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public bool IsRead { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string IpAdress { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;

    }
}
