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
     * Lavet af:    Mikkel
     * Bidraget af: 
    */
    public class DeleteAccessoryModel : PageModel
    {
        public Customer CustomerSession { get; set; }

        [BindProperty]
        public Accessory Accessory { get; set; }


        public IActionResult OnGet(string id)
        {
            AccessoryHandler aH = new AccessoryHandler();

            if (aH.Get(id) != null)
            {
                Accessory = aH.Get(id);
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

            if (Accessory != null)
            {
               
                aH.Delete(Accessory.Id);
                
                return RedirectToPage("MenuTable");
            }
            return RedirectToPage("MenuTable");
        }
    }
}
