using E_Commerce.Core.Interfaces;
using E_Commerce.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IRepositoryProduct prodRepo;
        private readonly IRepositoryUser usersRepo;

        public MainBusinessLayer(IRepositoryProduct productRepository, IRepositoryUser userRepository)
        {
            this.prodRepo = productRepository;
            this.usersRepo = userRepository;
        }

        public List<Product> FetchProducts()
        {
            return prodRepo.Fetch();
        }

        public bool AddProduct(Product newProduct)
        {
            if (newProduct == null)
            {
                return false;
            }
            else
            {
                return prodRepo.Add(newProduct);
            }
        }

        public bool DeleteProduct(int idProduct)
        {
            if (idProduct <= 0)
            {
                return false;
            }
            else
            {
                Product productToDelete = prodRepo.GetById(idProduct);

                if (productToDelete != null)
                {
                    return prodRepo.Delete(productToDelete.Id);
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UpdateProduct(Product product)
        {
            if (product == null)
            {
                return false;
            }
            else
            {
                return prodRepo.Update(product);
            }
        }

        public Product GetProductByCode(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return null;
            }
            return prodRepo.GetProductByCode(code);
        }

        public Product GetProductById(int id)
        {
            if (id <= 0)
            {
                return null;
            }
            return prodRepo.GetById(id);
        }

        public User GetAccount(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return null;
            }
            return usersRepo.GetByUsername(username);
        }

    }
}
