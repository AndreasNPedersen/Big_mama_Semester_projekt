using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadOrderingssystem.Models;
using MadOrderingssystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MadOrderingssystem.Pages.MenuPage
{
    public class DeletePageModel : PageModel
    {
        private string id { get; set; }
        [BindProperty]
        public Product product { get; set; }

        public void OnGet(string newid)
        {
            id = newid;
            ProductHandler productHandler = new ProductHandler();
            product = productHandler.Get(id);
        }

        public IActionResult OnPost()
        {
            ProductHandler productHandler = new ProductHandler();
            if (product != null)
            {
                productHandler.Delete(id);
                return RedirectToPage("MenuTable");
            }
            return RedirectToPage("MenuTable");
        }
    }
}
