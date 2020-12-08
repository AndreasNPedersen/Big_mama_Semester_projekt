using MadOrderingssystem.Data;
using MadOrderingssystem.Interfaces;
using MadOrderingssystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Services
{
    public class OrderHandler : IManagement<Order>
    {
        private string filePath = @"C:\Users\andre\source\repos\andr12f4\Big_mama_Semester_projekt\Madorderingssystem\Data\DataOrders.json";
        public void Create(Order order)
        {
            JsonOrder jsonOrder = new JsonOrder();
            order.ID = Guid.NewGuid().ToString();
            Dictionary<string, Order> dic = jsonOrder.ReadJsonFile(filePath);
            dic.Add(order.ID,order);
            jsonOrder.WriteJsonFile(dic, filePath);
        }

        public void Delete(string id)
        {
            JsonOrder jsonOrder = new JsonOrder();
            Dictionary<string, Order> dic = jsonOrder.ReadJsonFile(filePath);
            dic.Remove(id);
            jsonOrder.WriteJsonFile(dic, filePath);
        }

        public Dictionary<string, Order> FilterDictionary(string filter)
        {
            JsonOrder jsonOrder = new JsonOrder();
            Dictionary<string, Order> dic = jsonOrder.ReadJsonFile(filePath);
            Dictionary<string, Order> dicC = new Dictionary<string, Order>();
            foreach (Order order in dic.Values)
            {
                if (order.ID.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(order.ID, order);
                }
                if (order.customer.ID.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(order.ID, order);
                }
            }
            return dicC;
        }

        public Order Get(string id)
        {
            JsonOrder jsonOrder = new JsonOrder();
            Dictionary<string, Order> dic = jsonOrder.ReadJsonFile(filePath);
            return dic[id];
        }

        public Dictionary<string, Order> GetDictionary()
        {
            JsonOrder jsonOrder = new JsonOrder();
            return jsonOrder.ReadJsonFile(filePath);
            
        }

        public void Update(Order order, string id)
        {
            JsonOrder jsonOrder = new JsonOrder();
            Dictionary<string, Order> dic = jsonOrder.ReadJsonFile(filePath);
            dic[id] = order;
            jsonOrder.WriteJsonFile(dic, filePath);
        }
    }
}
