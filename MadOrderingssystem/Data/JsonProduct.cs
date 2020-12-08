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
    public class JsonProduct
    {
        public Dictionary<string,Product> ReadJsonFile(string filePath)
        {
            string input = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Dictionary<string, Product>>(input);
        }

        public void WriteJsonFile(Dictionary<string,Product> dic, string filePath)
        {
           string output = JsonConvert.SerializeObject(dic, Formatting.Indented);
           File.WriteAllText(filePath,output);
        }

    }
}
