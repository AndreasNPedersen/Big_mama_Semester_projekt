using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MadOrderingssystem.Models;
using MadOrderingssystem.Data;
using MadOrderingssystem.Services;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace MadOrderingssystem.Pages.MenuPage
{
    public class MainMenuModel : PageModel
    {
        
        
        public Dictionary<string, Pizza> DicPizza { get; set; }
        public Dictionary<string, Menu> DicMenu { get; set; }
        public Dictionary<string, Accessory> DicAccessories { get; set; }
        public Dictionary<string, Toppings> DicToppings { get; set; }
        private DateTime DateTimeNow { get; set; }
        private bool AlcoholTime { get; set; }
        public List<Product> Basket { get; set; }
        

        public IActionResult OnGet()
        {
            DateTimeNow = DateTime.Now;
            DicMenu = new MenuHandler().GetDictionary();
            DicAccessories = new AccessoryHandler().GetDictionary();
            DicToppings = new ToppingHandler().GetDictionary();
            DicPizza = new PizzaHandler().GetDictionary();
            
            // checks the time for the alcohol to show
            if (DateTimeNow.Hour > 22 || DateTimeNow.Hour < 5) { AlcoholTime = true; }
            foreach(Accessory accessory in DicAccessories.Values)
            {
                if (AlcoholTime == true)
                {
                    DicAccessories.Remove(accessory.Id);
                }         
            }

            try
            {
                Basket = JsonConvert.DeserializeObject<List<Product>>(HttpContext.Session.GetString("basket"));
            }
            catch (ArgumentNullException ex) { }

            return Page();
        }

        public IActionResult OnGetBuy(string id)
        {
            AccessoryHandler aH = new AccessoryHandler();
            MenuHandler mH = new MenuHandler();
            PizzaHandler pH = new PizzaHandler();
            ToppingHandler tH = new ToppingHandler();
            if (aH.Get(id) != null)
            {
                Basket.Add(aH.Get(id));
            }
            if (mH.Get(id) != null)
            {
                Basket.Add(mH.Get(id));
            }
            if (pH.Get(id) != null)
            {
                Basket.Add(pH.Get(id));
            }
            if (tH.Get(id) != null)
            {
                Basket.Add(tH.Get(id));
            }
            HttpContext.Session.SetString("basket", JsonConvert.SerializeObject(Basket));
            return Page();
        }
        
        public void OnPost()
        {
            //lav dette i onGet metode
            //lav hvert object kald objected i button, save det, add det
            
            
            
        }

    }
}
