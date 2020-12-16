using MadOrderingssystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Data
{
    /*
     * Lavet af:    Andreas
     * Bidraget af: 
    */
    public class JsonTopping
    {
        public Dictionary<string, Toppings> ReadJsonFile(string filePath)
        {

            string input = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<Dictionary<string, Toppings>>(input); ;
        }

        public void WriteJsonFile(Dictionary<string, Toppings> dic, string filePath)
        {
            string output = JsonConvert.SerializeObject(dic, Formatting.Indented);
            File.WriteAllText(filePath, output);
        }

    }
}

