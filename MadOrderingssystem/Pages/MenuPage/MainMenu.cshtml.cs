using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MadOrderingssystem.Models;
using MadOrderingssystem.Data;
using MadOrderingssystem.Services;

namespace MadOrderingssystem.Pages.MenuPage
{
    public class MainMenuModel : PageModel
    {
        
        
        public Dictionary<string, Pizza> DicPizza { get; set; }
        public Dictionary<string, Menu> DicMenu { get; set; }
        public Dictionary<string, Accessory> DicAccessories { get; set; }
        public Dictionary<string, Toppings> DicToppings { get; set; }
        private DateTime DateTimeNow { get; set; }
        private bool AlcoholTime { get; set; }
        [BindProperty]
        public List<Product> Basket { get; set; }

        public void OnGet()
        {
            DateTimeNow = DateTime.Now;
            
            // checks the time for the alcohol
            if (DateTimeNow.Hour < 22 || DateTimeNow.Hour > 5) { AlcoholTime = true; }
            if (AlcoholTime == false)
            {
                 DicAccessories.Add(accessory.Id, accessory);
            }         
                    
  
        }

    }
}
