using MadOrderingssystem.Data;
using MadOrderingssystem.Interfaces;
using MadOrderingssystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Services
{
    public class ToppingHandler : IManagement<Toppings>
    {
<<<<<<< HEAD
        private string filePath = @"C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Data\DataToppings.json";
=======
        private string filePath = @"D:\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Data\DataToppings.json";
>>>>>>> 5292a5178b673545a7ebf60df583e81a3f07d43f
        public void Create(Toppings toppings)
        {
            JsonTopping jsonTopping = new JsonTopping();
            toppings.Id = Guid.NewGuid().ToString();
            Dictionary<string, Toppings> dic = jsonTopping.ReadJsonFile(filePath);
            dic.Add(toppings.Id, toppings);
            jsonTopping.WriteJsonFile(dic, filePath);
        }

        public void Delete(string id)
        {
            JsonTopping jsonTopping = new JsonTopping();
            Dictionary<string, Toppings> dic = jsonTopping.ReadJsonFile(filePath);
            dic.Remove(id);
            jsonTopping.WriteJsonFile(dic, filePath);
        }

        public Dictionary<string, Toppings> FilterDictionary(string filter)
        {
            //need the filtering of pizza toppings
            JsonTopping jsonTopping = new JsonTopping();
            Dictionary<string, Toppings> dic = jsonTopping.ReadJsonFile(filePath);
            Dictionary<string, Toppings> dicC = new Dictionary<string, Toppings>();
            foreach (Toppings toppings in dic.Values)
            {
                if (toppings.Id.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(toppings.Id, toppings);
                }
                if (toppings.ProductName.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(toppings.Id, toppings);
                }
            }
            return dicC;
        }

        public Toppings Get(string id)
        {
            JsonTopping jsonTopping = new JsonTopping();
            Dictionary<string, Toppings> dic = jsonTopping.ReadJsonFile(filePath);
            return dic[id];
        }

        public Dictionary<string, Toppings> GetDictionary()
        {
            JsonTopping jsonTopping = new JsonTopping();
            return jsonTopping.ReadJsonFile(filePath);
        }

        public void Update(Toppings newTopping, string id)
        {
            JsonTopping jsonTopping = new JsonTopping();
            Dictionary<string, Toppings> dic = jsonTopping.ReadJsonFile(filePath);
            dic[id] = newTopping;
            jsonTopping.WriteJsonFile(dic, filePath);
        }
    }
}