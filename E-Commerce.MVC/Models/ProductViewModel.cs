using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.MVC.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public decimal SupplierPrice { get; set; }
        public string Description { get; set; }
        public ProductType Type { get; set; }

    }
}
