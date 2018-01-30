using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    class UserModel
    {
        public int Id { get; set; }
        [StringLength(50), Required]
        public string Name { get; set; }
        [StringLength(50), Required, EmailAddress]
        public string Email { get; set; }
        [StringLength(15), Required, Phone, RegularExpression("" ,ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public DateTime JoinDate { get; set; }

        public ICollection<ProductModel> Products { get; set; }
        public ICollection<ReviewsModel> CustomerReviews { get; set; }
    }
}
