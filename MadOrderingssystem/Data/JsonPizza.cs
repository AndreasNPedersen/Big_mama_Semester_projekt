using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MadOrderingssystem.Models;
using Newtonsoft.Json;

namespace MadOrderingssystem.Data
{
    /*
     * A basic Json Reader and Writer, that takes a Dictionary with objects
     * only needs a dictionary and a file path
     * -Andreas
    */
    public class JsonPizza
    {
        public Dictionary<string, Pizza> ReadJsonFile(string filePath)
        {

            string input = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<Dictionary<string, Pizza>>(input); ;
        }

        public void WriteJsonFile(Dictionary<string, Pizza> dic, string filePath)
        {
            string output = JsonConvert.SerializeObject(dic, Formatting.Indented);
            File.WriteAllText(filePath, output);
        }

    }

}
}
