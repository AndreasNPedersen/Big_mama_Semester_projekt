using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Models
{
    //Andreas
    public class Customer
    {
        public string CustomerDiscount {get;set;}
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PostNumber { get; set; }
        public string Password { get; set; }
        public Guid ID { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

    }
}
