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

namespace MadOrderingssystem.Pages.Login
{
    public class Log_registreModel : PageModel
    {
        [BindProperty]
        public Customer CustomerSession { get; set; }
        [BindProperty]
        public Customer Customer { get; set; }
        
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
                if (Customer.Role == 0) { Customer.Role = Roles.Customer; Customer.CustomerDiscount = true; }

                CustomerHandler cH = new CustomerHandler();
                cH.Create(Customer);

                return RedirectToPage("/Index");
            }
            return Page();
                      
        }
    }
}
