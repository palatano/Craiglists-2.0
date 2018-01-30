using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        [StringLength(50), Required]
        public string Name { get; set; }
        [StringLength(512), Required]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        
    }
}
