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
        [BindProperty]
        public Dictionary<string, Accessory> DicAccessories { get; set; }
        public Dictionary<string, Toppings> DicToppings { get; set; }
        private DateTime DateTimeNow { get; set; }
        private bool AlcoholTime { get; set; }
        [BindProperty]
        public List<Product> Basket { get; set; }
        [BindProperty(SupportsGet = true)]
        public string filtersøgning { get; set; }
        [BindProperty(SupportsGet = true)]
        public string filtersøgningIngredienser { get; set; }


        public IActionResult OnGet()
        {
            DateTimeNow = DateTime.Now;
            DicMenu = new MenuHandler().GetDictionary();
            DicAccessories = new AccessoryHandler().GetDictionary();
            DicToppings = new ToppingHandler().GetDictionary();
            DicPizza = new PizzaHandler().GetDictionary();
            
            // checks the time for the alcohol to show
            if (DateTimeNow.Hour < 22 || DateTimeNow.Hour > 5) { AlcoholTime = true; }
            foreach(Accessory accessory in DicAccessories.Values)
            {
                if (AlcoholTime == true)
                {
                    if (accessory.IsAlcohol) { 
                    DicAccessories.Remove(accessory.Id);
                    }
                }         
            }

            if (!string.IsNullOrEmpty(filtersøgning))
            {
                DicMenu = new MenuHandler().FilterDictionary(filtersøgning);
                DicAccessories = new AccessoryHandler().FilterDictionary(filtersøgning);
                DicToppings = new ToppingHandler().FilterDictionary(filtersøgning);
                DicPizza = new PizzaHandler().FilterDictionary(filtersøgning);
            }

            if (!string.IsNullOrEmpty(filtersøgningIngredienser))
            {
                filtersøgningIngredienser = "true" + filtersøgningIngredienser;
                DicPizza = new PizzaHandler().FilterDictionary(filtersøgningIngredienser);
            }
            try
            {
                Basket = JsonConvert.DeserializeObject<List<Product>>(HttpContext.Session.GetString("basket"));
            }
            catch (ArgumentNullException ex) { }

            return Page();
        }

       
        
        public IActionResult OnPostBuya(string id)
        {
            //lav dette i onGet metode
            //lav hvert object kald objected i button, save det, add det
            DicMenu = new MenuHandler().GetDictionary();
            DicAccessories = new AccessoryHandler().GetDictionary();
            DicToppings = new ToppingHandler().GetDictionary();
            DicPizza = new PizzaHandler().GetDictionary();
            try
            {
                Basket = JsonConvert.DeserializeObject<List<Product>>(HttpContext.Session.GetString("basket"));
            }
            catch (ArgumentNullException ex) { }
            if (new AccessoryHandler().Get(id) != null)
            {
                Basket.Add(new AccessoryHandler().Get(id));
            }
            
            HttpContext.Session.SetString("basket", JsonConvert.SerializeObject(Basket));
            return RedirectToPage("MainMenu");
        }

        public IActionResult OnPostBuyp(string id)
        {
            //lav dette i onGet metode
            //lav hvert object kald objected i button, save det, add det
            DicMenu = new MenuHandler().GetDictionary();
            DicAccessories = new AccessoryHandler().GetDictionary();
            DicToppings = new ToppingHandler().GetDictionary();
            DicPizza = new PizzaHandler().GetDictionary();
            try
            {
                Basket = JsonConvert.DeserializeObject<List<Product>>(HttpContext.Session.GetString("basket"));
            }
            catch (ArgumentNullException ex) { }
            if (new PizzaHandler().Get(id) != null)
            {
                Basket.Add(new PizzaHandler().Get(id));
            }

            HttpContext.Session.SetString("basket", JsonConvert.SerializeObject(Basket));
            return RedirectToPage("MainMenu");
        }

        public IActionResult OnPostBuym(string id)
        {
            //lav dette i onGet metode
            //lav hvert object kald objected i button, save det, add det
            DicMenu = new MenuHandler().GetDictionary();
            DicAccessories = new AccessoryHandler().GetDictionary();
            DicToppings = new ToppingHandler().GetDictionary();
            DicPizza = new PizzaHandler().GetDictionary();
            try
            {
                Basket = JsonConvert.DeserializeObject<List<Product>>(HttpContext.Session.GetString("basket"));
            }
            catch (ArgumentNullException ex) { }
            if (new MenuHandler().Get(id) != null)
            {
                Basket.Add(new MenuHandler().Get(id));
            }

            HttpContext.Session.SetString("basket", JsonConvert.SerializeObject(Basket));
            return RedirectToPage("MainMenu");
        }

    }
}
