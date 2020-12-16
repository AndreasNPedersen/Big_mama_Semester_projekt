using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Models
{
    /*
     * Lavet af:    Aleksandar
     * Bidraget af: 
    */
    public class Pizza : Product
    {
        
        public Size Size { get; set; }
        public List<Toppings> Topping { get; set; }
        public string Ingrediense { get; set; }
        public Pizza() { }
        public Pizza(Size size, string newId, double pris, string productName) : base(newId, pris, productName)
        {
            
        }   
    }

}

