using Himsug_Final4.Shared;
using Himsug_Final4.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Himsug_Final4.Server.Services
{ 

    public class SupplierManager : ISuppliers
    {
        readonly SupplierDBContext _supplierDB = new();
        public SupplierManager(SupplierDBContext supplierDB) 
        {
            _supplierDB = supplierDB;
        }
        public void AddSupplier(Supplier supplier)
        {
            try
            {
                _supplierDB.Suppliers.Add(supplier);
                _supplierDB.SaveChanges();
            }
            catch
            {
                throw;
            }

        }

        public void DeleteSupplier(int supplierID)
        {

            try
            {
                Supplier? supplier = _supplierDB.Suppliers.Find(supplierID);
                if (supplier != null)
                {
                    _supplierDB.Suppliers.Remove(supplier);
                    _supplierDB.SaveChanges();
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

        public Supplier GetSupplierID(int supplierID)
        {
            try
            {
                Supplier? supplier = _supplierDB.Suppliers.Find(supplierID);
                if (supplier != null)
                {
                    return supplier;
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

        public List<Supplier> GetSupplierDetails()
        {
            try
            {
                return _supplierDB.Suppliers.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateSupplier(Supplier supplier)
        {
            try
            {
                _supplierDB.Entry(supplier).State = EntityState.Modified;
                _supplierDB.SaveChanges();
            }
            catch 
            {
                throw;
            }
        }
    }


    
    
}
