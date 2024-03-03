using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Himsug_Final4.Shared.Models
{   
     public class Accounts
    {

        [Key] public int AccountsID { get; set; }

        [Required]
        public string Username { get; set; } 
        [Required]
        public string Password { get; set; }
        [Required]
        public string Access_Level { get; set; }

        //public string Emaddress { get; set; }

    }
}
