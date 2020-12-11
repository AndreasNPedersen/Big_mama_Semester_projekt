using MadOrderingssystem.Data;
using MadOrderingssystem.Interfaces;
using MadOrderingssystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Services
{
    public class PizzaHandler : IManagement<Pizza>
    {
        private string filePath = @"C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Data\DataPizza.json";
        public void Create(Pizza pizza)
        {
            JsonPizza jsonPizza = new JsonPizza();
            pizza.Id = Guid.NewGuid().ToString();
            Dictionary<string, Pizza> dic = jsonPizza.ReadJsonFile(filePath);
            dic.Add(pizza.Id, pizza);
            jsonPizza.WriteJsonFile(dic, filePath);
        }

        public void Delete(string id)
        {
            JsonPizza jsonPizza = new JsonPizza();
            Dictionary<string, Pizza> dic = jsonPizza.ReadJsonFile(filePath);
            dic.Remove(id);
            jsonPizza.WriteJsonFile(dic, filePath);
        }

        public Dictionary<string, Pizza> FilterDictionary(string filter)
        {
            //need the filtering of pizza toppings
            JsonPizza jsonPizza = new JsonPizza();
            Dictionary<string, Pizza> dic = jsonPizza.ReadJsonFile(filePath);
            Dictionary<string, Pizza> dicC = new Dictionary<string, Pizza>();
            foreach (Pizza pizza in dic.Values)
            {
                if (pizza.Id.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(pizza.Id, pizza);
                }
                if (pizza.ProductName.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(pizza.ProductName, pizza);
                }
            }
            return dicC;
        }

        public Pizza Get(string id)
        {
            JsonPizza jsonPizza = new JsonPizza();
            Dictionary<string, Pizza> dic = jsonPizza.ReadJsonFile(filePath);
            return dic[id];
        }

        public Dictionary<string, Pizza> GetDictionary()
        {
            JsonPizza jsonPizza = new JsonPizza();
            return jsonPizza.ReadJsonFile(filePath);
        }

        public void Update(Pizza newPizza, string id)
        {
            JsonPizza jsonPizza = new JsonPizza();
            Dictionary<string, Pizza> dic = jsonPizza.ReadJsonFile(filePath);
            dic[id] = newPizza;
            jsonPizza.WriteJsonFile(dic, filePath);
        }
    }
}
