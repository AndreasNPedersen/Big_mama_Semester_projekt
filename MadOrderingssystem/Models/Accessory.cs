﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Models
{
    /*
     * Lavet af:    Aleksandar
     * Bidraget af: 
    */
    public class Accessory : Product
    {

        public bool IsAlcohol { get; set; }
        public Accessory() { } //default constructor

        public Accessory(string newId, double pris, string productName) : base(newId, pris, productName)
        {

        }
    }
}