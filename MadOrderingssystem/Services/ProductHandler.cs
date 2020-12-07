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
            JsonRW jsonRW = new JsonRW();
            product.Id = Guid.NewGuid().ToString();
            Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePath);
            dic.Add(product.Id, product);
            jsonRW.WriteJsonFile(dic, filePath);
        }

        public void Delete(string id)
        {
            JsonRW jsonRW = new JsonRW();
            Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePath);
            dic.Remove(id);
            jsonRW.WriteJsonFile(dic, filePath);
        }

        public Dictionary<string, Product> FilterDictionary(string filter)
        {
            JsonRW jsonRW = new JsonRW();
            Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePath);
            Dictionary<string, Product> dicC = new Dictionary<string, Product>();
            foreach (Product product in dic.Values)
            {
                if (product.ID.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(product.Id, product);
                }
                if (product.customer.ID.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(order.ID, order);
                }
            }
            return dicC;
        }

        public Order Get(string id)
        {
            JsonRW jsonRW = new JsonRW();
            Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePath);
            return (Order)dic[id];
        }

        public Dictionary<string, Order> GetDictionary()
        {
            JsonRW jsonRW = new JsonRW();
            Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePath);
            Dictionary<string, Order> dicC = new Dictionary<string, Order();
            foreach (Order order in dic.Values)
            {
                dicC.Add(order.ID, order);
            }
            return dicC;
        }

        public void Update(Order order, string id)
        {
            JsonRW jsonRW = new JsonRW();
            Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePath);
            dic[id] = order;
            jsonRW.WriteJsonFile(dic, filePath);
        }
    }
}
