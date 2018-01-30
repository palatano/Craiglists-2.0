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
        bool SaveProducts(ProductModel productModel);
        List<ProductModel> displayProducts();
    }
}
