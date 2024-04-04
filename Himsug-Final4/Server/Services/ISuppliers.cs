using Himsug_Final4.Shared.Models;

namespace Himsug_Final4.Server.Services
{
    public interface ISuppliers
    {

        public List<Supplier> GetSupplierDetails();
        public void AddSupplier(Supplier supplier);

        public void UpdateSupplier(Supplier supplier);

        public void DeleteSupplier(int supplierID);

        public Supplier GetSupplierID(int supplierID);

    }
}
