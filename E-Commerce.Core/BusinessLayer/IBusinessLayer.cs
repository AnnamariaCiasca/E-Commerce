using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.BusinessLayer
{
   public interface IBusinessLayer
    {
        List<Product> FetchProducts();
        bool AddProduct(Product newProduct);
        bool DeleteProduct(int idProduct);
        bool UpdateProduct(Product product);
        Product GetProductById(int id);
        Product GetProductByCode(string code);
    }
}
