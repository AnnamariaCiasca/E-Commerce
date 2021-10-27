using System;

namespace E_Commerce.Core
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ProductType Type { get; set; }
        public decimal Price { get; set; }
        public decimal SupplierPrice { get; set; }
    }
}

public enum ProductType
{
    Electronic,
    Clothes,
    HomeLife
}
