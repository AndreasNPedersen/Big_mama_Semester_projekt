using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Interfaces
{
    /*
     * CRUD operations with a GetAll dictionary and a filter list
     * lavet af: Andreas
    */
    interface IManagement<T>
    {
        T Get(string id);
        void Create(T obj);
        void Update(T obj, string id);
        void Delete(string id);
        Dictionary<string, T> GetDictionary();
        Dictionary<string, T> FilterDictionary(string filterWord);
    }
}
