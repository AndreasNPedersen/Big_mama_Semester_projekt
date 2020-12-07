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
            JsonRW jsonRW = new JsonRW();
            order.ID = Guid.NewGuid().ToString();
            Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePath);
            dic.Add(order.ID,order);
            jsonRW.WriteJsonFile(dic, filePath);
        }

        public void Delete(string id)
        {
            JsonRW jsonRW = new JsonRW();
            Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePath);
            dic.Remove(id);
            jsonRW.WriteJsonFile(dic, filePath);
        }

        public Dictionary<string, Order> FilterDictionary(string filter)
        {
            JsonRW jsonRW = new JsonRW();
            Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePath);
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
