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
    public class AddMenuPageModel : PageModel
    {
        public Customer CustomerSession { get; set; }
        [BindProperty]
        public Menu Menu { get; set; }

        private Dictionary<string,Product> productList { get; set; }

        public void OnGet()
        {
            ProductHandler pH = new ProductHandler();
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
                foreach (Pizza product in Menu.Pizzas)
                {
                    if (product.IsSelsected)
                    {
                        productChoosenP.Add(product);
                    }
                }
                foreach(Accessory product in Menu.Accesories)
                {
                    if (product.IsSelsected)
                    {
                        productChoosenA.Add(product);
                    }
                }
                Menu.Pizzas = productChoosenP;
                Menu.Accesories = productChoosenA;
                ProductHandler pH = new ProductHandler();
                pH.Create(Menu);
                return Page();
            }
            return Page();
        }

    }
}
