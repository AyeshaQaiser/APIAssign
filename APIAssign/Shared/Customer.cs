using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAssign.Shared
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [MinLength(3)]
        [StringLength(22, ErrorMessage = "Length can't be more than 22 characters nor less than 3")]
        [Column(TypeName = "Varchar(20)")]
        public string Name { get; set; }
        [Column(TypeName = "Varchar(20)")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Column(TypeName = "Varchar(40)")]
        [Required]
        public string Address { get; set; }
        [Column(TypeName = "Varchar(80)")]
        [Required]
        public string City { get; set; }
    }
}
