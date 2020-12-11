using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadOrderingssystem.Models;
using MadOrderingssystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace MadOrderingssystem.Pages.MenuPage
{
    public class MenuTableModel : PageModel
    {
        public Dictionary<string, Toppings> DicTopping { get; set; }
        public Dictionary<string, Pizza> DicPizza { get; set; }
        public Dictionary<string, Menu> DicMenu { get; set; }
        public Dictionary<string, Accessory> DicAccessories { get; set; }
        public Customer CustomerSession { get; set; }
        

        public IActionResult OnGet()
        {
            try
            {
                CustomerSession = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("user"));
            }
            catch (ArgumentNullException ex) { }
            DicAccessories = new AccessoryHandler().GetDictionary();
            DicMenu = new MenuHandler().GetDictionary();
            DicPizza = new PizzaHandler().GetDictionary();
            DicTopping = new ToppingHandler().GetDictionary();
            return Page();
        }
    }
}
