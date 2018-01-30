using BL;
using Demo.IBLL;
using Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL
{
    class ProductManager : IProduct
    {
        DALContext ctx = new DALContext();

        public void Add(Product productModel)
        {
            ctx.Products.Add(productModel);
            ctx.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return ctx.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return ctx.Products.ToList();
        }

        public void Remove(int id)
        {
            var prod = (from prods in ctx.Products
                        where prods.Id == id
                        select prods).First();
            ctx.Products.Remove(prod);
            ctx.SaveChanges();
        }

        public void Update(Product product)
        {
            var prod = ctx.Products.Find(product.Id);
            prod.Name = product.Name;
            prod.Description = product.Description;
            prod.Price = product.Price;
            ctx.SaveChanges();
        }
    }
}
