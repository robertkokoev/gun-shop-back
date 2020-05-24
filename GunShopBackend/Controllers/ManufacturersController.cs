using System.Collections.Generic;
using System.Threading.Tasks;
using GunShopBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GunShopBackend.Controllers
{
    [Route("api/[controller]")]
    public class ManufacturersController : Controller
    {
        WeaponsContext db;
        public ManufacturersController(WeaponsContext context)
        {
            db = context;
        }

        // GET: api/manufacturers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Manufacturer>>> Get()
        {
            return await db.Manufacturers.ToListAsync();
        }

        // POST: api/<controller>
        [HttpPost]
        public async Task<ActionResult<Manufacturer>> Post([FromBody]Manufacturer manufacturer)
        {
            if (manufacturer == null)
            {
                return BadRequest();
            }

            db.Manufacturers.Add(manufacturer);
            await db.SaveChangesAsync();
            return Ok(manufacturer);
        }
    }
}
