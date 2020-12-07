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
    public class log_inModel : PageModel
    {
        [BindProperty]
        public Customer Customer { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            CustomerHandler customerHandler = new CustomerHandler();
            Customer=customerHandler.Get(Email, Password);
            if (Customer != null)
            {
            HttpContext.Session.SetString("user",JsonConvert.SerializeObject(Customer));
            return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
