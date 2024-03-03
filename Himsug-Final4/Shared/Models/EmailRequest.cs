using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Himsug_Final4.Shared.Models
{
    public class EmailRequest
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        

    }
}
