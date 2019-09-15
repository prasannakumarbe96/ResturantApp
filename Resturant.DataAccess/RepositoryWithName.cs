using System;
using System.Collections.Generic;
using System.Text;
using Resturant.Standard;
using Resturant.Module;
using System.Linq;
namespace Resturant.DataAccess
{
    public class RepositoryWithName<T> : Repository<T> where T : EntityWithName
    {
        public override IEnumerable<T> Get(string name)
        {
            return items.Values.Where(x => x.Name == name).ToList();
        }
        
    }
}
