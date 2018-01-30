using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(50), Required]
        public string Name { get; set; }
        [StringLength(512), Required]
        public string Description { get; set; }
        // Not shown in view.
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        public int UserId { get; set; }
        [Required, Range(0, Int32.MaxValue)]
        public decimal Price { get; set; }

    }
}
