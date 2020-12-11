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
    public class DeleteMenuModel : PageModel
    {
        public Customer CustomerSession { get; set; }

        [BindProperty]
        public Menu Menu { get; set; }
  

        public IActionResult OnGet(string id)
        { 
            MenuHandler mH = new MenuHandler();

            if (mH.Get(id) != null)
            {
                Menu = mH.Get(id);
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
            MenuHandler mH = new MenuHandler();

            if (Menu != null)
            {
                if (Menu is Menu)
                {
                    Menu = mH.Get(Menu.Id);
                }

                return RedirectToPage("MenuTable");
            }
            return RedirectToPage("MenuTable");
        }
    }
}
