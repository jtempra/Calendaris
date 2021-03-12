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
    public class DetallsPlantillesController : ControllerBase
    {

        private readonly CalendarisDbContext _context;

        public DetallsPlantillesController(CalendarisDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<DetallPlantillaCalendari>>> Get()
        {
            var detallsplantilles = await _context.DetallsPlantillesCalendari.ToListAsync();
            return Ok(detallsplantilles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DetallPlantillaCalendari>> Get(int id)
        {
            var detallsplantilla = await _context.DetallsPlantillesCalendari.FirstOrDefaultAsync(f => f.Id == id);
            return Ok(detallsplantilla);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(DetallPlantillaCalendari detallsplantilla)
        {
            _context.DetallsPlantillesCalendari.Add(detallsplantilla);
            await _context.SaveChangesAsync();
            return Ok(detallsplantilla.Id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(DetallPlantillaCalendari detallsplantilla)
        {
            _context.Attach(detallsplantilla).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existeix = await _context.DetallsPlantillesCalendari.AnyAsync(x => x.Id == id);
            if (!existeix) { return NotFound(); }
            _context.DetallsPlantillesCalendari.Remove(new DetallPlantillaCalendari() { Id = id });
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
