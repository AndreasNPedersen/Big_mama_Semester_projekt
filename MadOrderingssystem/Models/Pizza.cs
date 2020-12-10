using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Models
{
    public class Pizza : Product
    {
        
        public Size Size { get; set; }
        public List<Toppings> Topping { get; set; }
 

        public Pizza(Size size, string newId, double pris, string productName) : base(newId, pris, productName)
        {
            
        }   
    }

}

