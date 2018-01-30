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
        void Add(Product productModel);
        void Remove(int id);
        void Update(Product productModel);
        List<Product> GetProducts();
        Product GetProductById(int id);

    }
}
