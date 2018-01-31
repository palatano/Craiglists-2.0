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

        public List<Product> Get()
        {
            return ctx.Products.ToList();
        }

        public Product Get(int id)
        {
            return ctx.Products.Find(id);
        }

        public void Post(Product product)
        {
            ctx.Products.Add(product);
            ctx.SaveChanges();
        }

        public void Put(Product product)
        {
            var prod = ctx.Products.Find(product.Id);
            prod.Name = product.Name;
            prod.Description = product.Description;
            prod.Price = product.Price;
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var prod = (from prods in ctx.Products
                        where prods.Id == id
                        select prods).First();
            ctx.Products.Remove(prod);
            ctx.SaveChanges();
        }

    }
}
