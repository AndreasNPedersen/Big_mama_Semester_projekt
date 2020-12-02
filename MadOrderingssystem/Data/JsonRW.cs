using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MadOrderingssystem.Data
{
    /*
     * A basic Json Reader and Writer, that takes a Dictionary with objects
     * only needs a dictionary and a file path
     * -Andreas
    */
    public class JsonRW
    {
        public Dictionary<Guid,Object> ReadJsonFile(string filePath)
        {
            return JsonConvert.DeserializeObject<Dictionary<Guid, Object>>(filePath);
        }

        public void WriteJsonFile(Dictionary<Guid,Object> dic, string filePath)
        {
           string output = JsonConvert.SerializeObject(dic);
           File.WriteAllText(filePath,output);
        }

    }
}
