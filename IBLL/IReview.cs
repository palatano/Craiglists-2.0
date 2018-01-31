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
        void Post(Review review);
        void Delete(int id);
        void Put(Review review);
        List<Review> Get();
        Review Get(int id);
    }
}
