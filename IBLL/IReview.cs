using Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IReview
    {
        /* CRUD operations */
        void Add(Review review);
        void Remove(int id);
        void Update(Review review);
        List<Review> GetReviews();
        Review GetReviewById(int id);
    }
}
