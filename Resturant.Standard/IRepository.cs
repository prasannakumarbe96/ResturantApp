using System;
using System.Collections.Generic;
using System.Text;

namespace Resturant.Standard
{
  public  interface  IRepository<T> where T:EntityBase
    {
        bool Add(T obj);
        T Get(Guid Id);
        bool Update(T obj);
        bool Remove(Guid Id);
        IEnumerable<T> GetAll();
    }
}
