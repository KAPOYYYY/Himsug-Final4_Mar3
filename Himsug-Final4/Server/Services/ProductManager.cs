﻿using Himsug_Final4.Shared;
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

        //addproduct
        public void AddProduct(Product product)
        {
            try
            {
                _productDB.tbl_ProductDetail.Add(product);
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
                Product? product = _productDB.tbl_ProductDetail.Find(productID);
                if (product != null)
                {
                    _productDB.tbl_ProductDetail.Remove(product);
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
                Product? person = _productDB.tbl_ProductDetail.Find(productID);
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
                return _productDB.tbl_ProductDetail.ToList();
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

        
    

