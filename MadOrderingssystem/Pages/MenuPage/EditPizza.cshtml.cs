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
    public class EditPizzaModel : PageModel
    {

        public Customer CustomerSession { get; set; }

        [BindProperty]
        public Pizza Pizza { get; set; }


        public void OnGet(string id)
        {
            PizzaHandler pH = new PizzaHandler();
            Pizza = pH.Get(id);
            try
            {
                CustomerSession = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("user"));
            }
            catch (ArgumentNullException ex) { }


        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            PizzaHandler pH = new PizzaHandler();
            pH.Update(Pizza, Pizza.Id);

            return RedirectToPage("MenuTable");

        }
    }

}