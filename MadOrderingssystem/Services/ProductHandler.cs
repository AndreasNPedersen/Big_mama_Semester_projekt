using MadOrderingssystem.Data;
using MadOrderingssystem.Interfaces;
using MadOrderingssystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Services
{
    public class ProductHandler:IManagement<Product>
    {
        private string filePath = @"C:\Users\andre\source\repos\andr12f4\Big_mama_Semester_projekt\Madorderingssystem\Data\DataProducts.json";
        public void Create(Product product)
        {
            JsonProduct jsonProduct = new JsonProduct();
            product.Id = Guid.NewGuid().ToString();
            Dictionary<string, Product> dic = jsonProduct.ReadJsonFile(filePath);
            dic.Add(product.Id, product);
            jsonProduct.WriteJsonFile(dic, filePath);
        }

        public void Delete(string id)
        {
            JsonProduct jsonProduct = new JsonProduct();
            Dictionary<string, Product> dic = jsonProduct.ReadJsonFile(filePath);
            dic.Remove(id);
            jsonProduct.WriteJsonFile(dic, filePath);
        }

        public Dictionary<string, Product> FilterDictionary(string filter)
        {
            //need the filtering of pizza toppings
            JsonProduct jsonProduct = new JsonProduct();
            Dictionary<string, Product> dic = jsonProduct.ReadJsonFile(filePath);
            Dictionary<string, Product> dicC = new Dictionary<string, Product>();
            foreach (Product product in dic.Values)
            {
                if (product.Id.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(product.Id, product);
                }
                if (product.ProductName.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(product.ProductName, product);
                }
            }
            return dicC;
        }

        public Product Get(string id)
        {
            JsonProduct jsonProduct = new JsonProduct();
            Dictionary<string, Product> dic = jsonProduct.ReadJsonFile(filePath);
            return dic[id];
        }

        public Dictionary<string, Product> GetDictionary()
        {
            JsonProduct jsonProduct = new JsonProduct();
            return jsonProduct.ReadJsonFile(filePath);
        }

        public void Update(Product product, string id)
        {
            JsonProduct jsonProduct = new JsonProduct();
            Dictionary<string, Product> dic = jsonProduct.ReadJsonFile(filePath);
            dic[id] = product;
            jsonProduct.WriteJsonFile(dic, filePath);
        }
    }
}
