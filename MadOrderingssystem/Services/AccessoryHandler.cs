using MadOrderingssystem.Data;
using MadOrderingssystem.Interfaces;
using MadOrderingssystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Services
{
    public class AccessoryHandler : IManagement<Accessory>
    {
        private string filePath = @"C:\Users\andre\Desktop\Zealand  Datamatiker\1 Semester\Semester Projekt\Big_mama_Semester_projekt\MadOrderingssystem\Data\DataAccessories.json";
        public void Create(Accessory accessory)
        {
            JsonAccessory jsonAccessory = new JsonAccessory();
            accessory.Id = Guid.NewGuid().ToString();
            Dictionary<string, Accessory> dic = jsonAccessory.ReadJsonFile(filePath);
            dic.Add(accessory.Id, accessory);
            jsonAccessory.WriteJsonFile(dic, filePath);
        }

        public void Delete(string id)
        {
            JsonAccessory jsonAccessory = new JsonAccessory();
            Dictionary<string, Accessory> dic = jsonAccessory.ReadJsonFile(filePath);
            dic.Remove(id);
            jsonAccessory.WriteJsonFile(dic, filePath);
        }

        public Dictionary<string, Accessory> FilterDictionary(string filter)
        {
            //need the filtering of pizza toppings
            JsonAccessory jsonAccessory = new JsonAccessory();
            Dictionary<string, Accessory> dic = jsonAccessory.ReadJsonFile(filePath);
            Dictionary<string, Accessory> dicC = new Dictionary<string, Accessory>();
            foreach (Accessory accessory in dic.Values)
            {
                if (accessory.Id.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(accessory.Id, accessory);
                }
                if (accessory.ProductName.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(accessory.Id, accessory);
                }
            }
            return dicC;
        }

        public Accessory Get(string id)
        {
            JsonAccessory jsonAccessory = new JsonAccessory();
            Dictionary<string, Accessory> dic = jsonAccessory.ReadJsonFile(filePath);
            return dic[id];
        }

        public Dictionary<string, Accessory> GetDictionary()
        {
            JsonAccessory jsonAccessory = new JsonAccessory();
            return jsonAccessory.ReadJsonFile(filePath);
        }

        public void Update(Accessory newAccessory, string id)
        {
            JsonAccessory jsonAccessory = new JsonAccessory();
            Dictionary<string, Accessory> dic = jsonAccessory.ReadJsonFile(filePath);
            dic[id] = newAccessory;
            jsonAccessory.WriteJsonFile(dic, filePath);
        }
    }
}

