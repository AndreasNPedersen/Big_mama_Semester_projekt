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
    public class AddAccessoryPageModel : PageModel
    {
        public Customer CustomerSession { get; set; }

        [BindProperty]
        public Accessory Accessory { get; set; }
        [BindProperty]
        public bool IsAlcohol { get; set; }

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
                               
                AccessoryHandler aH = new AccessoryHandler();
                aH.Create(Accessory);

                return RedirectToPage("MenuTable");
                
            }   
            return Page();
        }
    }
}
