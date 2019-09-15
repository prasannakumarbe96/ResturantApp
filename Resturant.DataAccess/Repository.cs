using System;
using System.Collections.Generic;
using Resturant.Standard;
namespace Resturant.DataAccess
{
    public  class Repository<T> : IRepository<T> where T:EntityBase
    {
        public IDictionary<Guid, T> items;
      public  Repository()
        {
            items = new Dictionary<Guid,T>();
        }
        public bool Add(T obj)
        {
            
          
         items.Add(obj.Id, obj);
            return true;
        }
        public virtual IEnumerable<T> Get(string name)
        {
            return null;
        }


        public T Get(Guid Id)
        {
            return items[Id];
        }

        public bool Update(T obj)
        {
            items[obj.Id] = obj;
            return true;
        }

        public bool Remove(Guid Id)
        {
            items.Remove(Id);
            return true;
        }

        public IEnumerable<T> GetAll()
        {
            return items.Values;
        }

      
      
    }
}
