using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MadOrderingssystem.Models;
using MadOrderingssystem.Data;

namespace MadOrderingssystem.Pages.Menu
{
    public class MenuModel : PageModel
    {
        [BindProperty]
        public static Product ProductSession { get; }
        [BindProperty]
        public static Product Product { get; set; }

        public static Dictionary<string, Product> dicC = new Dictionary<string, Product>();



        private string filePath = @"D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Data\DataProducts.json";
        public static string ProductData = System.IO.File.ReadAllText("./Data/DataProducts.json");

        public void OnGet()
        {



            dicC.Add("1", new Product("A", 222, "A") { Id = "1", Price = 222, ProductName = "eee" });


            //JsonRW jsonRW = new JsonRW();
            //Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePath);

            //foreach (var product in dic.Values)
            //{

            //    //dicC.Add(product.Id, product);
            //}



            //     JsonRW jsonRW = new JsonRW();
            //     Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePath);

            //     foreach (Product product in dic.Values)
            //     {
            //         dicC.Add(product.Id, product);
            //      }
        }
    }
}
