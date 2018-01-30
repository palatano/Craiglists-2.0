using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    class ReviewsModel
    {
        // TODO: Add server side validation. Error messages.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, Range(0, 5)]
        public decimal Rating { get; set; }
        [Required, StringLength(512)]
        public string Description { get; set; }
        [Required]
        public bool Recommend { get; set; }
        public int UserId { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
