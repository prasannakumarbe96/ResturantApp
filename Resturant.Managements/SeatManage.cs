using System;
using Resturant.Standard;
using Resturant.Module;
using System.Collections.Generic;
namespace Resturant.Managements
{
    public  class SeatManage
    {
        public static IDictionary<Guid, Seating> templist = new Dictionary<Guid, Seating>();
        public static IDictionary<Guid, Seating> templist1 = new Dictionary<Guid, Seating>();
        public static void Show(Guid id)
        {
            Seating seat = templist[id];
            templist.Remove(id);
            templist1.Add(seat.Id, seat);
        }
        public static void Hide(Seating obj)
        {
            templist.Add(obj.Id, obj);
        }
    }
}
