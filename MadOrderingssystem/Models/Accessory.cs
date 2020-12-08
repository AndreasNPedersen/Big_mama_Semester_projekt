using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Models
{
    public class Accessory : Product
    {
        public Accessory(string newId, double pris, string productName) : base(newId, pris, productName)
        {

        }
    }
}