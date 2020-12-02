using MadOrderingssystem.Data;
using MadOrderingssystem.Interfaces;
using MadOrderingssystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Services
{
    /*
     * The Handler that either gets or sets a customer (CRUD operations)
     * The Data handler
     * -Andreas
    */
    public class ObjectHandler : IManagement
    {
        private string filePath = @"";
        public void Create(Object obj)
        {

            if (obj is Customer) { }
            Customer customer = (Customer)obj;
            JsonRW jsonRW = new JsonRW();
            Dictionary<Guid, Object> dic = jsonRW.ReadJsonFile(filePath);
            dic.Add(customer.ID,customer);
            jsonRW.WriteJsonFile(dic, filePath);
        }

        public void Delete(Guid id)
        {
            JsonRW jsonRW = new JsonRW();
            Dictionary<Guid, Object> dic = jsonRW.ReadJsonFile(filePath);
            dic.Remove(id);
            jsonRW.WriteJsonFile(dic, filePath);
        }

        public Dictionary<Guid, Object> FilterDictionary()
        {
            throw new NotImplementedException();
        }

        public object Get(Guid id)
        {
            JsonRW jsonRW = new JsonRW();
            Dictionary<Guid, Object> dic = jsonRW.ReadJsonFile(filePath);
            return (Customer)dic[id];
        }

        public Dictionary<Guid, Object> GetDictionary()
        {
            return  new JsonRW().ReadJsonFile(filePath);
        }

        public void Update(object obj, Guid id)
        {
            JsonRW jsonRW = new JsonRW();
            Dictionary<Guid, Object> dic = jsonRW.ReadJsonFile(filePath);
            dic[id] = (Customer)obj;
            jsonRW.WriteJsonFile(dic, filePath);
        }
    }
}
