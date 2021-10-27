using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Interfaces
{
    public interface IRepositoryProduct : IRepository<Product>
    {
        public Product GetProductByCode(string code);
    }
}
