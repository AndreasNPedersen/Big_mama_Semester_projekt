using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadOrderingssystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MadOrderingssystem.Pages.Login
{
    public class ProfilModel : PageModel
    {
    public Customer CustomerSession { get; }
        public void OnGet()
        {
        }
    }
}
