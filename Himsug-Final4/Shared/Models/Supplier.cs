using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Himsug_Final4.Shared.Models
{
    public class Supplier
    {
        [Key] public int SupplierID { get; set; }

        public string SupplierName { get; set; }

        public string Address { get; set; }

        public int ContactNumber { get; set; }

        public string ItemName { get; set; }

        public decimal Price { get; set; }

        public int TotalOrderItems { get; set; }

        public int TotalCost { get; set; }

        public DateOnly DateAdded { get; set; }

        public DateOnly PackageDeliveredDate { get; set; }

        public bool is_deleted { get; set; }
    }
}
