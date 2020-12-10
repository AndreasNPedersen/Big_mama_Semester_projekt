using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadOrderingssystem.Models;
using MadOrderingssystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MadOrderingssystem.Pages.MenuPage
{
    public class MenuTableModel : PageModel
    {
        public Dictionary<string, Toppings> DicTopping { get; set; }
        public Dictionary<string, Pizza> DicPizza { get; set; }
        public Dictionary<string, Menu> DicMenu { get; set; }
        public Dictionary<string, Accessory> DicAccessories { get; set; }
        

        public IActionResult OnGet()
        {
            DicAccessories = new AccessoryHandler().GetDictionary();
            DicMenu = new MenuHandler().GetDictionary();
            DicPizza = new PizzaHandler().GetDictionary();
            DicTopping = new ToppingHandler().GetDictionary();
            return Page();
        }
    }
}
