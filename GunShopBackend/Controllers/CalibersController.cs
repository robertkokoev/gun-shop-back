using System.Collections.Generic;
using System.Threading.Tasks;
using GunShopBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GunShopBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalibersController : Controller
    {
        WeaponsContext db;

        public CalibersController(WeaponsContext context)
        {
            db = context;
        }

        // GET: api/calibers
        [HttpGet]
        public async Task<IEnumerable<Caliber>> Get()
        {
            return await db.Calibers.ToListAsync();
        }

        // PUT api/calibers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/calibers/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
