using System;
using System.Collections.Generic;
using System.Text;
using Resturant.Standard;
namespace Resturant.Module
{
    public abstract class EntityWithName:EntityBase
    {
        public string Name { get; set; }
    }
}
