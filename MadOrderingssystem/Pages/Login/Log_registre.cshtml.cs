using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadOrderingssystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MadOrderingssystem.Pages.Login
{
    public class Log_registreModel : PageModel
    {

        public Customer customer { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            ObjectHandler cH = new ObjectHandler();
            

            return RedirectToPage("index");
        }
    }
}
