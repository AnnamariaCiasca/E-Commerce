using E_Commerce.Core;
using E_Commerce.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E_Commerce.EF
{
    public class RepositoryProductEF : IRepositoryProduct
    {
        private readonly AmazonContext ctx;

        public RepositoryProductEF(AmazonContext context)
        {
            this.ctx = context;
        }

        public List<Product> Fetch()
        {
            try
            {
                return ctx.Products.ToList();
            }
            catch (Exception)
            {
                return new List<Product>();
            }
        }


        public bool Add(Product item)
        {
            if (item == null)
            {
                return false;
            }
            try
            {
                ctx.Products.Add(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                string message = ex.Message;
                return false;
            }
        }



        public bool Delete(int id)
        {
            if (id <= 0)
            {
                return false;
            }
            try
            {
                var product = ctx.Products.Find(id);

                if (product != null)

                    ctx.Products.Remove(product);
                    ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

      
        public bool Update(Product updatedItem)
        {
            if (updatedItem == null)
            {
                return false;
            }
            try
            {
                ctx.Products.Update(updatedItem);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Product GetById(int id)
        {
            if (id <= 0)
            {
                return null;
            }
            return ctx.Products.Find(id);
        }

        public Product GetProductByCode(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return null;
            }
            return ctx.Products.FirstOrDefault(e => e.Code == code);
        }



    }
}