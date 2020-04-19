using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GunShopBackend.Models;

namespace GunShopBackend.Controllers
{
    [Route("api/[controller]")]
    public class WeaponsController : Controller
    {
        WeaponsContext db;
        public WeaponsController(WeaponsContext context)
        {
            db = context;
        }

        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Weapon>>> Get()
        {
            return await db.Weapons.ToListAsync();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<Weapon>> Post([FromBody]Weapon weapon)
        {
            if (weapon == null)
            {
                return BadRequest();
            }

            db.Weapons.Add(weapon);
            await db.SaveChangesAsync();
            return Ok(weapon);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
