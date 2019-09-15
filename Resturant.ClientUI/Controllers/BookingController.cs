using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Resturant.DataAccess;
using Resturant.Module;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Resturant.ClientUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        public Repository<Booking> _booking;
      public  BookingController(Repository<Booking> booking)
        {
            _booking = booking;

        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            return _booking.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Booking Get(Guid id)
        {
            return _booking.Get(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Booking value)
        {
            _booking.Add(value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]Booking value)
        {
            _booking.Update(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _booking.Remove(id);
        }
    }
}
