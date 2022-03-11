using System;
using System.Collections.Generic;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;

namespace GraphQlProject.Services
{
    public class ProductService : IProduct
    {
        private static readonly List<Product> Products = new()
        {
            new Product { Id = 0, Name = "Coffee", Price = 10 },
            new Product { Id = 1, Name = "Tea", Price = 15 },
        };

        public List<Product> GetAllProducts()
        {
            return Products;
        }

        public Product AddProduct(Product product)
        {
            Products.Add(product);
            return product;
        }

        public Product UpdateProduct(int id, Product product)
        {
            Products[id] = product;
            return product;
        }

        public void DeleteProduct(int id)
        {
            Products.RemoveAt(id);
        }

        public Product GetProductById(int id)
        {
            return Products.Find(p => p.Id == id);
        }
    }
}
