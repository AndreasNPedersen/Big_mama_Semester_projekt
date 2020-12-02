using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadOrderingssystem.Interfaces
{
    /*
     * CRUD operations with a GetAll dictionary and a filter list
     * -Andreas
    */
    interface IManagement
    {
        object Get(Guid id);
        void Create(Object obj);
        void Update(Object obj, Guid id);
        void Delete(Guid id);
        Dictionary<Guid, Object> GetDictionary();
        Dictionary<Guid, Object> FilterDictionary();
    }
}
