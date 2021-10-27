using E_Commerce.Core;
using E_Commerce.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.MVC.Helper
{
    public static class Mapping
    {
        public static ProductViewModel ToProductViewModel(this Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                Code = product.Code,
                Price = product.Price,
                Type = product.Type,
                Description = product.Description,
                SupplierPrice = product.SupplierPrice
            };
        }

        public static Product ToProduct(this ProductViewModel prodViewModel)
        {
            return new Product
            {
                Id = prodViewModel.Id,
                Code = prodViewModel.Code,
                Description = prodViewModel.Description,
                Price = prodViewModel.Price,
                Type = prodViewModel.Type,
                SupplierPrice = prodViewModel.SupplierPrice
            };
        }

    }
}
