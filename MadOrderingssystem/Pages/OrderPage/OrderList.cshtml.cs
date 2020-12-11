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

namespace MadOrderingssystem.Pages.OrderPage
{
    public class OrderListModel : PageModel
    {
        
        public Dictionary<string, Order> OrderListTable { get; set; }
        
        public Customer CustomerSession { get; set; }

        public void OnGet()
        {
            try
            {
                CustomerSession = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("user"));
            }
            catch (ArgumentNullException ex) { }
            OrderListTable = new OrderHandler().GetDictionary();
        }
    }
}
