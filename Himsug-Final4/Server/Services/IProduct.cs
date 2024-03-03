using Himsug_Final4.Shared.Models;

namespace Himsug_Final4.Server.Services
{
    public interface IProduct
    {
        
        public List<Product> GetProducts();

        public void AddProduct(Product product);

        public void UpdateProduct(Product product);

        public void DeleteProduct(int productID);

        public Product GetProductID(int productID);
    }   
}
