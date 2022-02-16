using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.Models
{
    public class UpdateAdminImage
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string NameSurname { get; set; }
        public string Phone { get; set; }
        public IFormFile Image { get; set; }
        public string Address { get; set; }
    }
}
