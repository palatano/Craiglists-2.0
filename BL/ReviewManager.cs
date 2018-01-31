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

        public List<Review> Get()
        {
            return ctx.Reviews.ToList();
        }

        public Review Get(int id)
        {
            return ctx.Reviews.Find(id);
        }

        public void Post(Review review)
        {
            ctx.Reviews.Add(review);
            ctx.SaveChanges();
        }

        public void Put(Review review)
        {
            var rev = ctx.Reviews.Find(review.Id);
            rev.Description = review.Description;
            rev.Recommend = review.Recommend;
            rev.Rating = review.Rating;
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var rev = ctx.Reviews.Find(id);
            ctx.Reviews.Remove(rev);
            ctx.SaveChanges();
        }

    }
}
