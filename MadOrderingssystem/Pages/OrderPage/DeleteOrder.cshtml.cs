using System;
using MadOrderingssystem.Models;
using MadOrderingssystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace MadOrderingssystem.Pages.OrderPage
{
    /*
     * Lavet af:    Mikkel
     * Bidraget af: 
    */
    public class DeleteOrderModel : PageModel
    {
        public Customer CustomerSession { get; set; }

        [BindProperty]
        public Order Order { get; set; }


        public IActionResult OnGet(string id)
        {
            OrderHandler oH = new OrderHandler();
            Order = oH.Get(id);
            try
            {
                CustomerSession = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("user"));
            }
            catch (ArgumentNullException ex) { }
            return Page();
        }

        public IActionResult OnPost()
        {
            OrderHandler oH = new OrderHandler();
            oH.Delete(Order.ID);

            return RedirectToPage("OrderList");
        }
    }
}
