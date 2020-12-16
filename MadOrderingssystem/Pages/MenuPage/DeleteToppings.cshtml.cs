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
     * Lavet af:    Aleksandar
     * Bidraget af: 
    */
    public class DeleteToppingsModel : PageModel
    {
        public Customer CustomerSession { get; set; }

        [BindProperty]
        public Toppings Topping { get; set; }


        public IActionResult OnGet(string id)
        {
            ToppingHandler tH = new ToppingHandler();

            if (tH.Get(id) != null)
            {
                Topping = tH.Get(id);
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
            ToppingHandler tH = new ToppingHandler();
            if (Topping != null)
            {
                tH.Delete(Topping.Id);
                
                return RedirectToPage("MenuTable");
            }
            return RedirectToPage("MenuTable");
        }
    }
}

