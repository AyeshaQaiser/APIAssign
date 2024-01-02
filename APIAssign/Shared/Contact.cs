using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAssign.Shared
{
    public class Contact
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [MinLength(3)]
        [StringLength(22, ErrorMessage = "Length can't be more than 22 characters nor less than 3")]
        public string name { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [EmailAddress]
        public string email { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [StringLength(150, ErrorMessage = "Length can't be more than 22 characters nor less than 3")]
        public string message { get; set; }
    }
}
