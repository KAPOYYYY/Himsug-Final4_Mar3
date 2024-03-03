using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Himsug_Final4.Shared.Models
{
    public class Product
    {
        [Key] public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? Unit { get; set; }
        public decimal UnitPrice { get; set; }

        public int QuantityInStock { get; set; }
            
        public DateOnly ArrivalDate { get; set; }

        public DateOnly ExpirationDate { get; set; }

        public int SupplierID { get; set; }

        public bool is_deleted { get; set; }
    }
}
