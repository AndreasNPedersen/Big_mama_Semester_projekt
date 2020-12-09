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
        
        private Dictionary<string, Product> DicProduct { get; set; }
        public Dictionary<string, Pizza> DicPizza { get; set; }
        public Dictionary<string, Menu> DicMenu { get; set; }
        public Dictionary<string, Accessory> DicAccessories { get; set; }
        [BindProperty]
        public List<Product> Basket { get; set; }

        public void OnGet()
        {
        
            ProductHandler pH = new ProductHandler();
            DicProduct = pH.GetDictionary();
            foreach (Product product in DicProduct.Values)
            {
                if (product is Pizza)
                {
                    Pizza pizza = (Pizza)product;
                    DicPizza.Add(pizza.Id, pizza);
                }
                if (product is Menu)
                {
                    Menu menu = (Menu)product;
                    DicMenu.Add(menu.Id, menu);
                }
                if (product is Accessory)
                {
                    Accessory accessory = (Accessory)product;
                    DicAccessories.Add(accessory.Id, accessory);
                }
            }
            
        }

    }
}
