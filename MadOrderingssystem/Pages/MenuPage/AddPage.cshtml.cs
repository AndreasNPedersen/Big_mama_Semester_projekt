using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MadOrderingssystem.Models;
using MadOrderingssystem.Services;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace MadOrderingssystem.Pages.MenuPage
{
    public class AddPageModel : PageModel
    {
        public Customer CustomerSession { get; set; }
        private string id { get; set; }
        public string exeptionMSG { get; set; }
        [BindProperty]
        public Product Product { get; set; }
        public void OnGet()
        {
            //try
            //{
            //    CustomerSession = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("user"));
            //}
            //catch (ArgumentNullException ex) { exeptionMSG = "Du er ikke logget ind"; }

        }



        public IActionResult OnPost()
            {
               
              

               ProductHandler ProductHandler = new ProductHandler();
                ProductHandler.Create(Product);

                return RedirectToPage("/Index");

            }

        
        
    }
}
