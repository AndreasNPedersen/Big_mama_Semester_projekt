using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MadOrderingssystem.Models;
using MadOrderingssystem.Services;

namespace MadOrderingssystem.Pages.OrderPage
{
    public class OrderListModel : PageModel
    {
        [BindProperty]
        public Dictionary<string, MadOrderingssystem.Models.Order> OrderListTable { get; set; }
        [BindProperty]
        public Customer CustomerSession { get; set; }

        public void OnGet()
        {
        }
    }
}
