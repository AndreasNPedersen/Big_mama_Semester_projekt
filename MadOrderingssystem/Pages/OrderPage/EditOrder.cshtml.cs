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

namespace MadOrderingssystem.Pages.OrderPage
{
    public class EditOrderModel : PageModel
    {


        public Customer CustomerSession { get; set; }
        [BindProperty]
        public Order Order { get; set; }



        public void OnGet(string id)
        {
            OrderHandler oH = new OrderHandler();
            Order = oH.Get(id);
            try
            {
                CustomerSession = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("user"));
            }
            catch (ArgumentNullException ex) { }


        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            OrderHandler oH = new OrderHandler();
            oH.Update(Order, Order.ID);

            return RedirectToPage("OrderList");

        }
    }
}
