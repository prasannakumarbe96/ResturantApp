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
    public class SeatingController : ControllerBase
    {
       public RepositoryWithName<Seating> _seats;
        SeatingController(RepositoryWithName<Seating> seats)
        {
            _seats = seats;

        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Seating> Get()
        {
            return _seats.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Seating Get(Guid id)
        {
            return _seats.Get(id);
        }
        [HttpGet("{id}")]
        public IEnumerable<Seating> Get(string name)
        {
            return _seats.Get(name);
        }


        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Seating value)
        {
            _seats.Add(value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]Seating value)
        {
            _seats.Update(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _seats.Remove(id);
        }
    }
}
