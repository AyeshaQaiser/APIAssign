using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAssign.Shared
{
    public class SignUp
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [MinLength(3)]
        [StringLength(22, ErrorMessage = "Length can't be more than 22 characters nor less than 3")]
        [Column(TypeName = "Varchar(20)")]
        public string name { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [EmailAddress]
        [Column(TypeName = "Varchar(20)")]
        public string email { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [PasswordPropertyText]
        [DataType(DataType.Password)]
        [StringLength(8, ErrorMessage = "Length can't be more than 8 characters")]
        [Column(TypeName = "Varchar(20)")]
        public string password { get; set; }
    }
}
