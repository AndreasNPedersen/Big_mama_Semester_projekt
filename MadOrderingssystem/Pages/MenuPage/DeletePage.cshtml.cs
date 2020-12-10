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
    public class DeletePageModel : PageModel
    {
        public Customer CustomerSession { get; set; }

        [BindProperty]
        public Product Product { get; set; }
  

        public IActionResult OnGet(string id)
        { 
            AccessoryHandler aH = new AccessoryHandler();
            MenuHandler mH = new MenuHandler();
            PizzaHandler pH = new PizzaHandler();
            ToppingHandler tH = new ToppingHandler();
            if (aH.Get(id) != null)
            {
                Product = aH.Get(id);
            }
            if (mH.Get(id) != null)
            {
                Product = mH.Get(id);
            }
            if (pH.Get(id) != null)
            {
                Product = pH.Get(id);
            }
            if (tH.Get(id) != null)
            {
                Product = tH.Get(id);
            }
            try
            {
                CustomerSession = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("user"));
            }
            catch (ArgumentNullException ex) { }
            return Page();
        }

        public IActionResult OnPost()
        {
            AccessoryHandler aH = new AccessoryHandler();
            MenuHandler mH = new MenuHandler();
            PizzaHandler pH = new PizzaHandler();
            ToppingHandler tH = new ToppingHandler();
            if (Product != null)
            {
                if (Product is Accessory)
                {
                    Product = aH.Get(Product.Id);
                }
                if (Product is Menu)
                {
                    Product = mH.Get(Product.Id);
                }
                if (Product is Pizza)
                {
                    Product = pH.Get(Product.Id);
                }
                if (Product is Toppings)
                {
                    Product = tH.Get(Product.Id);
                }
                return RedirectToPage("MenuTable");
            }
            return RedirectToPage("MenuTable");
        }
    }
}
