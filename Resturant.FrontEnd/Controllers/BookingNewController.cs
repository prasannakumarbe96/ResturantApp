using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resturant.DataAccess;
using Resturant.Module;
using Resturant.Managements;
namespace Resturant.FrontEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingNewController : ControllerBase
    {
        private readonly Repository<Booking> bookings;
      
        public BookingNewController(Repository<Booking> booking)
        {
            this.bookings = booking;
            IEnumerator<Seating> list = SeatManage.templist1.Values.GetEnumerator();
            IEnumerator<Booking> booklist = this.bookings.GetAll().GetEnumerator();
            while (list.MoveNext())
            {
                while (booklist.MoveNext())
                {
                    if (list.Current.Id == booklist.Current.SeatId)
                    {
                        //DateTimeOffset offset ;
                        //DateTimeOffset.TryParse(booklist.Current.EndTime, out offset);
                        //if ( DateTimeOffset.Now >=offset  )
                        //{
                        //   Seating seat= SeatManage.templist1[booklist.Current.SeatId];
                        //    SeatManage.Hide(seat);
                        //    this.Delete(booklist.Current.Id);

                        //}
                      var checkDate=  DateTime.Compare(DateTime.Now, booklist.Current.EndTime);
                        if (checkDate >= 0)
                        {
                            Seating seat= SeatManage.templist1[booklist.Current.SeatId];
                            SeatManage.Hide(seat);
                            this.Delete(booklist.Current.Id);

                        }
                    }
                    else
                    {
                        booklist = this.bookings.GetAll().GetEnumerator();
                    }
                }
               
            }

        }
        // GET: api/Booking
        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            return this.bookings.GetAll();
        }

        // GET: api/Booking/5
        [HttpGet("{id}", Name = "Bookings")]
        public Booking Get(Guid id)
        {
            return this.bookings.Get(id);

        }

        // POST: api/Booking
        [HttpPost]
        public bool Post([FromBody] Booking booking)
        {
           
            if (!this.bookings.items.ContainsKey(booking.Id) && !SeatManage.templist1.ContainsKey(booking.SeatId))
            {
                SeatManage.Show(booking.SeatId);
               return this.bookings.Add(booking);
            }
            else
            {
                return false;
            }
            
        }

        // PUT: api/Booking/5
        [HttpPut("{id}")]
        public bool Put(Guid id, [FromBody] Booking booking)
        {
            if (this.bookings.items.ContainsKey(booking.Id))
            {
                return this.bookings.Update(booking);
            }
            else
            {
                return false;
            }
          
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            if (this.bookings.items.ContainsKey(id))
            {
                return
                       this.bookings.Remove(id);
            }
            else
            {
                return false;
            }
        }
    }
}
