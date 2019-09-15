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
    public class SeatingNewController : ControllerBase
    {
        private readonly RepositoryWithName<Seating> seatings;
        public SeatingNewController(RepositoryWithName<Seating> seating)
        {
          
            this.seatings = seating;
              SeatManage.templist = seatings.items;
          
        }
        // GET: api/Seating
        [HttpGet]
        public IEnumerable<Seating> Get()
        {
            return SeatManage.templist.Values;
        }

        // GET: api/Seating/5
        [HttpGet("{id}", Name = "Seatings")]
        public Seating Get(Guid id)
        {
            return this.seatings.Get(id);
        }

       
        // GET: api/Seating/Prasanna
        [HttpGet("{name}", Name = "SeatsWithSameName")]
        public IEnumerable<Seating> Get(string name)
        {

            return this.seatings.Get(name);
        }

       

        // POST: api/Seating
        [HttpPost]
        public bool Post([FromBody] Seating seating)
        {
            if (!this.seatings.items.ContainsKey(seating.Id))
           {
            //    SeatManage.Hide(seating);
                return this.seatings.Add(seating);
            }
            else
            {
                return false;
            }
     
        }

        // PUT: api/Seating/5
        [HttpPut("{id}")]
        public bool Put(Guid id, [FromBody] Seating seating)
        {
            if (this.seatings.items.ContainsKey(seating.Id))
            {
                return this.seatings.Update(seating);
            }
            else
            {
                return false;
            }
           
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public  bool Delete(Guid id)
        {

            if (this.seatings.items.ContainsKey(id))
            {
                return this.seatings.Remove(id);
            }
            else
            {
                return false;
            }
           

        }
    }
}
