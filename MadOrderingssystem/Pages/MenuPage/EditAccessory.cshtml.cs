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
    public class EditAccessoryModel : PageModel
    {

        public Customer CustomerSession { get; set; }

        [BindProperty]
        public Accessory Accessory { get; set; }


        public void OnGet(string id)
        {
            AccessoryHandler aH = new AccessoryHandler();
            Accessory = aH.Get(id);
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

            AccessoryHandler aH = new AccessoryHandler();
            aH.Update(Accessory, Accessory.Id);

            return RedirectToPage("MenuTable");

        }
    }

}
