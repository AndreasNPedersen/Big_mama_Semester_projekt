using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadOrderingssystem.Models;
using MadOrderingssystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MadOrderingssystem.Pages.Login
{
    public class Log_registreModel : PageModel
    {
        [BindProperty]
        public Customer CustomerSession { get; }
        [BindProperty]
        public Customer Customer { get; set; }
        


        public void OnGet()
        {
            //session ID skal tage det ind i CustomerSession
        }

        public IActionResult OnPost()
        {
            if (Customer.Role==0) { Customer.Role = Roles.Customer; Customer.CustomerDiscount = true; }
            
            CustomerHandler cH = new CustomerHandler();
            cH.Create(Customer);

            return RedirectToPage("/Index"); // retunere fejl
        }
    }
}
