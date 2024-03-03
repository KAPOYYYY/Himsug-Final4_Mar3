using Himsug_Final4.Shared;
using Himsug_Final4.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Himsug_Final4.Server.Services
{
    public class ProductManager : IProduct
    {
        readonly ProductDBContext _productDB = new();

        public ProductManager(ProductDBContext productDB)
        {
            _productDB = productDB;
        }

        public void AddProduct(Product product)
        {
            try
            {
                _productDB.Product.Add(product);
                _productDB.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteProduct(int productID)
        {
            try
            {
                Product? product = _productDB.Product.Find(productID);
                if (product != null)
                {
                    _productDB.Product.Remove(product);
                    _productDB.SaveChanges();
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

        public Product GetProductID(int productID)
        {
            try
            {
                Product? person = _productDB.Product.Find(productID);
                if (person != null)
                {
                    return person;
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

        public List<Product> GetProducts()
        {
            try
            {
                return _productDB.Product.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                _productDB.Entry(product).State = EntityState.Modified;
                _productDB.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}

       
