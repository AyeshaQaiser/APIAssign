using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAssign.Shared
{
    public class Product
    {
        [Key]
        public int product_id { get; set; }
        [Column(TypeName = "Varchar(20)")]

        public string product_name { get; set; }
        [Column(TypeName = "Varchar(20)")]
        public string product_price { get; set; }
        [Column(TypeName = "Varchar(20)")]
        public int Customer_id { get; set; }

        public Customer customer { get; set; } = null!;
    }
}
