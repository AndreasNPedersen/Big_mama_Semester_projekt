using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadOrderingssystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace MadOrderingssystem.Pages.Login
{
    public class ProfilModel : PageModel
    {
    public Customer CustomerSession { get; set; }
        public void OnGet()
        {
            CustomerSession = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("user"));
        }
    }
}
