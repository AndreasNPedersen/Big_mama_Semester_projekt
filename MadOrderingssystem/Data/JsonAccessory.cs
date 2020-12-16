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
     * Lavet af:    Andreas
     * Bidraget af: 
    */
    public class JsonAccessory
    {
        public Dictionary<string,Accessory> ReadJsonFile(string filePath)
        {

            string input = File.ReadAllText(filePath);
            
            return JsonConvert.DeserializeObject<Dictionary<string, Accessory>>(input); ;
        }

        public void WriteJsonFile(Dictionary<string,Accessory> dic, string filePath)
        {
           string output = JsonConvert.SerializeObject(dic, Formatting.Indented);
           File.WriteAllText(filePath,output);
        }

    }
}
