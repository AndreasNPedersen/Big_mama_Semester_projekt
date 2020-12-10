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
            ProductHandler pH = new ProductHandler();
            Product = pH.Get(id);
            try
            {
                CustomerSession = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("user"));
            }
            catch (ArgumentNullException ex) { }
            return Page();
        }

        public IActionResult OnPost()
        {
            ProductHandler pH = new ProductHandler();
            if (Product != null)
            {
                pH.Delete(Product.Id);
                return RedirectToPage("MenuTable");
            }
            return RedirectToPage("MenuTable");
        }
    }
}
