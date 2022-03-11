using System.Collections.Generic;
using System.Linq;
using GraphQlProject.Data;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;

namespace GraphQlProject.Services
{
    public class ProductService : IProductService
    {
        private readonly GraphQlDbContext _dbContext;

        public ProductService(GraphQlDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }

        public Product UpdateProduct(int id, Product product)
        {
            var entityProduct = _dbContext.Products.Find(id);
            entityProduct.Name = product.Name;
            entityProduct.Price = product.Price;
            _dbContext.SaveChanges();
            return product;
        }

        public void DeleteProduct(int id)
        {
            var entityProduct = _dbContext.Products.Find(id);
            _dbContext.Products.Remove(entityProduct);
            _dbContext.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return _dbContext.Products.Find(id);
        }
    }
}
