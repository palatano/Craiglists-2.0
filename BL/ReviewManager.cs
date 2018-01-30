using Demo.Model;
using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class ReviewManager : IReview
    {
        DALContext ctx = new DALContext();

        public void Add(Review review)
        {
            ctx.Reviews.Add(review);
            ctx.SaveChanges();
        }

        public Review GetReviewById(int id)
        {
            return ctx.Reviews.Find(id);
        }

        public List<Review> GetReviews()
        {
            return ctx.Reviews.ToList();
        }

        public void Remove(int id)
        {
            var rev = ctx.Reviews.Find(id);
            ctx.Reviews.Remove(rev);
            ctx.SaveChanges();
        }

        public void Update(Review review)
        {
            var rev = ctx.Reviews.Find(review.Id);
            rev.Description = review.Description;
            rev.Recommend = review.Recommend;
            rev.Rating = review.Rating;
            ctx.SaveChanges();
        }
    }
}
