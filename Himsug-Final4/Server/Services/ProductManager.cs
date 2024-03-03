using Himsug_Final4.Shared;
using Himsug_Final4.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Himsug_Final4.Server.Services
{
    public class ProductManager : IProduct
    {
        private readonly ProductDBContext _dbContext;

        public ProductManager(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //addproduct
        public void AddProduct(Product product)
        {
            try
            {
                _dbContext.Product.Add(product);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //deleteproduct
        public void DeleteProduct(int productID)
        {  
           try
            {
                Product? product = _dbContext.Product.Find(productID);
                if (product != null)
                {
                    _dbContext.Product.Remove(product);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        //getproducts
        public List<Product> GetProducts()
        {
            try
            {
                return  _dbContext.Product.ToList();
            }
            catch
            {
                throw;
            }

        }
        //getproductbyID
        public Product GetProductID(int productID)
        {
            try
            {
                Product? product = _dbContext.Product.Find(productID);
                if (product != null)
                {
                    return product;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        //updateproduct
        public void UpdateProduct(Product product)
        {
            try
            {
                _dbContext.Entry(product).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        
    }
}
