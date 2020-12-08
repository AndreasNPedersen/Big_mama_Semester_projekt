using MadOrderingssystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Data
{
    public class JsonCustomer
    {
        public Dictionary<string, Customer> ReadJsonFile(string filePath)
        {
            string input = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Dictionary<string, Customer>>(input);
        }

        public void WriteJsonFile(Dictionary<string, Customer> dic, string filePath)
        {
            string output = JsonConvert.SerializeObject(dic, Formatting.Indented);
            File.WriteAllText(filePath, output);
        }
    }
}
