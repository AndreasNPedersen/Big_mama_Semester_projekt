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
    public class CustomerHandler
    {
        //change when using other data route

        private string filePathCustomer = @"C:\Users\mukke\Documents\GitHub\Big_mama_Semester_projekt\MadOrderingssystem\Data\DataCustomer.json";

        public void Create(Customer customer)
        {
            customer.ID = Guid.NewGuid().ToString();
            customer.Date = DateTime.Now;
            JsonCustomer jsonCustomer = new JsonCustomer();
            Dictionary<string, Customer> dic = jsonCustomer.ReadJsonFile(filePathCustomer);
            dic.Add(customer.ID,customer);
            jsonCustomer.WriteJsonFile(dic, filePathCustomer);
        }

        public void Delete(string id)
        {
            JsonCustomer jsonCustomer = new JsonCustomer();
            Dictionary<string, Customer> dic = jsonCustomer.ReadJsonFile(filePathCustomer);
            dic.Remove(id);
            jsonCustomer.WriteJsonFile(dic, filePathCustomer);
        }

        public Dictionary<string, Customer> FilterDictionary(string filter)
        {
            JsonCustomer jsonCustomer = new JsonCustomer();
            Dictionary<string, Customer> dic = jsonCustomer.ReadJsonFile(filePathCustomer);
            Dictionary<string, Customer> dicC = new Dictionary<string, Customer>();
            foreach (Customer customer in dic.Values)
            {
                if (customer.Name.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(customer.ID, customer);
                }
                if (customer.LastName.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(customer.ID, customer);
                }
                if (customer.PhoneNumber.ToLower().Contains(filter.ToLower()))
                {
                    dicC.Add(customer.ID, customer);
                }
                if (customer.PostNumber.ToString().Contains(filter))
                {
                    dicC.Add(customer.ID, customer);
                }
                if (customer.Role.ToString().ToLower().Contains(filter))
                {
                    dicC.Add(customer.ID, customer);
                }
            }
            return dicC;
        }

        public Customer Get(string email,string password)
        {
            JsonCustomer jsonCustomer = new JsonCustomer();
            Dictionary<string, Customer> dic = jsonCustomer.ReadJsonFile(filePathCustomer);
            
            foreach(Customer customer in dic.Values)
            {
                if (customer.Email == email && customer.Password == password) { return customer; }
                
            }
            return null;
        }

        public Customer Get(string ID)
        {
            JsonCustomer jsonCustomer = new JsonCustomer();
            Dictionary<string, Customer> dic = jsonCustomer.ReadJsonFile(filePathCustomer);
            return dic[ID];
        }

        public Dictionary<string, Customer> GetDictionary()
        {
            JsonCustomer jsonCustomer = new JsonCustomer();
            Dictionary<string, Customer> dic = jsonCustomer.ReadJsonFile(filePathCustomer);
            
            return dic;
        }

        public void Update(Customer customer, string id)
        {
            JsonCustomer jsonCustomer = new JsonCustomer();
            Dictionary<string, Customer> dic = jsonCustomer.ReadJsonFile(filePathCustomer);
            dic[id] = customer;
            jsonCustomer.WriteJsonFile(dic, filePathCustomer);
        }
    }
}
