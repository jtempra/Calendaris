using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calendaris.Server.Contextes;
using Calendaris.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Calendaris.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlantillesController : ControllerBase
    {

        private readonly CalendarisDbContext _context;

        public PlantillesController(CalendarisDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<PlantillaCalendari>>> Get()
        {
            var plantilles = await _context.PlantillesCalendari.ToListAsync();
            return Ok(plantilles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PlantillaCalendari>> Get(int id)
        {
            var plantilla = await _context.PlantillesCalendari.FirstOrDefaultAsync(f => f.Id == id);
            return Ok(plantilla);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(PlantillaCalendari plantilla)
        {
            _context.Add(plantilla);
            await _context.SaveChangesAsync();
            return Ok(plantilla.Id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(PlantillaCalendari plantilla)
        {
            _context.Attach(plantilla).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existeix = await _context.PlantillesCalendari.AnyAsync(x => x.Id == id);
            if (!existeix) { return NotFound(); }
            _context.PlantillesCalendari.Remove(new PlantillaCalendari() { Id = id });
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
