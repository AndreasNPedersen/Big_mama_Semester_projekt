using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MadOrderingssystem.Models;
using Newtonsoft.Json;
using MadOrderingssystem.Services;
using Microsoft.AspNetCore.Http;

namespace MadOrderingssystem.Pages.MenuPage
{
    public class AddPizzaPageModel : PageModel
    {
       
        public Customer CustomerSession { get; set; }

        [BindProperty]
        public Pizza Pizza { get; set; }

        public void OnGet()
        {
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


                PizzaHandler pH = new PizzaHandler();
                pH.Create(Pizza);
                
                return RedirectToPage("MenuTable");

            }
            return Page();

        }
    }
}
