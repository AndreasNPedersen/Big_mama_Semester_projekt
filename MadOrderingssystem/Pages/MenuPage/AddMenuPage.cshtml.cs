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
    /*
     * Lavet af:    Andreas
     * Bidraget af: Aleksandar
    */
    public class AddMenuPageModel : PageModel
    {
        public Customer CustomerSession { get; set; }
        [BindProperty]
        public Dictionary<string,Pizza> DicPizzas { get; set; }
        [BindProperty]
        public Dictionary<string,Accessory> DicAccessories { get; set; }
        [BindProperty]
        public Menu Menu { get; set; }


        public void OnGet()
        {
            DicPizzas = new PizzaHandler().GetDictionary();
            DicAccessories = new AccessoryHandler().GetDictionary();
            MenuHandler mH = new MenuHandler();
            try
            {
                CustomerSession = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("user"));
            }
            catch (ArgumentNullException ex) { }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                List<Pizza> productChoosenP = new List<Pizza>();
                List<Accessory> productChoosenA = new List<Accessory>();
                foreach (Pizza product in DicPizzas.Values)
                {
                    if (product.IsSelsected)
                    {
                        productChoosenP.Add(product);
                    }
                }
                foreach(Accessory product in DicAccessories.Values)
                {
                    if (product.IsSelsected)
                    {
                        productChoosenA.Add(product);
                    }
                }
                Menu.Pizzas = productChoosenP;
                Menu.Accesories = productChoosenA;
                MenuHandler mH = new MenuHandler();
                mH.Create(Menu);
                return RedirectToPage("MenuTable");
            }
            return Page();
        }

    }
}
