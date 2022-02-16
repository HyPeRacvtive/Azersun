using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.Models
{
    public class UpdateSetting
    {
        public int Id { get; set; }
        public IFormFile Logo { get; set; }
        public string ProjectText { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public string Map { get; set; }
    }
}
