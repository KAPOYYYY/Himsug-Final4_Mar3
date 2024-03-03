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
        //AddPerson
        public void AddSupplier(Supplier supp)
        {
            try
            {
                _supplierDB.Suppliers.Add(supp);
                _supplierDB.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //DeletePerson
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
        //List Persons
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
        //GetPersonID
        public Supplier GetSupplier(int supplierID)
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
        //UpdatePerson
        public void UpdateSupplier(Supplier supp)
        {
            try
            {
                _supplierDB.Entry(supp).State = EntityState.Modified;
                _supplierDB.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}