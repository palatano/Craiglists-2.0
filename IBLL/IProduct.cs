using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Model;

namespace Demo.IBLL
{
    public interface IProduct
    {
        /* CRUD operations */
        void Post(Product productModel);
        void Delete(int id);
        void Put(Product productModel);
        List<Product> Get();
        Product Get(int id);

    }
}
