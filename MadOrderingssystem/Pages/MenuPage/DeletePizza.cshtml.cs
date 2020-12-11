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
    public class DeletePizzaModel : PageModel
    {
        public Customer CustomerSession { get; set; }

        [BindProperty]
        public Pizza Pizza { get; set; }


        public IActionResult OnGet(string id)
        {
            PizzaHandler pH = new PizzaHandler();

            if (pH.Get(id) != null)
            {
                Pizza = pH.Get(id);
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
            PizzaHandler tH = new PizzaHandler();
            if (Pizza != null)
            {
               tH.Delete(Pizza.Id);
                
                return RedirectToPage("MenuTable");
            }
            return RedirectToPage("MenuTable");
        }
    }
}
