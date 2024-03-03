using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Himsug_Final4.Shared.Models
{
    public class Person
    {
        [Key] public int PersonID { get; set; }
        [Required]
        public string Fname { get; set; }
        [Required]
        public string Mname { get; set; }
        [Required]
        public string Lname { get; set; }
        [Required]
        public string Email { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string Contact_Num { get; set; }

        public DateOnly Bdate { get; set; }

        public int AccountsID { get; set; }
    }
}
