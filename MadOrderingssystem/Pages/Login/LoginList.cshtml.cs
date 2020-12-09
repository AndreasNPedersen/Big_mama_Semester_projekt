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
    public class LoginListModel : PageModel
    {
        [BindProperty]
        public Dictionary<string,Customer> DicC { get; set; }
        [BindProperty]
        Customer customerSession { get; set; }

        public IActionResult OnGet()
        {
            CustomerHandler ch = new CustomerHandler();
            DicC=ch.GetDictionary();
            return Page();
        }
    }
}
