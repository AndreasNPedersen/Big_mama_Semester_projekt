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
    public class CustomerHandler : IManagement<Customer>
    {
        //change when using other data route
        private string filePathCustomer = @"C:\Users\andre\source\repos\andr12f4\Big_mama_Semester_projekt\Madorderingssystem\Data\DataCustomer.json";
        public void Create(Customer customer)
        {
            customer.ID = Guid.NewGuid().ToString();
            customer.Date = DateTime.Now;
            JsonRW jsonRW = new JsonRW();
            Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePathCustomer);
            dic.Add(customer.ID,customer);
            jsonRW.WriteJsonFile(dic, filePathCustomer);
        }

        public void Delete(string id)
        {
            JsonRW jsonRW = new JsonRW();
            Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePathCustomer);
            dic.Remove(id);
            jsonRW.WriteJsonFile(dic, filePathCustomer);
        }

        public Dictionary<string, Customer> FilterDictionary(string filter)
        {
            JsonRW jsonRW = new JsonRW();
            Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePathCustomer);
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

        public Customer Get(string id)
        {
            JsonRW jsonRW = new JsonRW();
            Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePathCustomer);
            return (Customer)dic[id];
        }

        public Dictionary<string, Customer> GetDictionary()
        {
            JsonRW jsonRW = new JsonRW();
            Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePathCustomer);
            Dictionary<string, Customer> dicC = new Dictionary<string, Customer>();
            foreach (Customer customer in dic.Values)
            {
                dicC.Add(customer.ID, customer);
            }
            return dicC;
        }

        public void Update(Customer customer, string id)
        {
            JsonRW jsonRW = new JsonRW();
            Dictionary<string, object> dic = jsonRW.ReadJsonFile(filePathCustomer);
            dic[id] = customer;
            jsonRW.WriteJsonFile(dic, filePathCustomer);
        }
    }
}
