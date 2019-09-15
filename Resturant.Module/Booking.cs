using System;
using System.Collections.Generic;
using System.Text;
using Resturant.Standard;
namespace Resturant.Module
{
    public class Booking:EntityBase
    {
     
        public Guid SeatId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        //public string StartTime { get; set; }
        //public string EndTime { get; set; }
        public int NoOfSeats { get; set; }
    }
}
