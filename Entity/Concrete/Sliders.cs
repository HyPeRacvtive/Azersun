using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Sliders
    {
        [Key]
        public int Id { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
    }
}
