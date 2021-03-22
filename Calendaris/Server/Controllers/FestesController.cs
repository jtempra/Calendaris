using Calendaris.Server.Contextes;
using Calendaris.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calendaris.Client.Repos;

namespace Calendaris.Server.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class FestesController : ControllerBase
    {

        private readonly CalendarisDbContext _context;

        public FestesController(CalendarisDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<CalendariFestes>>> Get()
        {
            var festes = await _context.CalendarisFestes.ToListAsync();

            return Ok(festes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CalendariFestes>> Get(int id)
        {
            var festa = await _context.CalendarisFestes.FirstOrDefaultAsync(f => f.Id == id);
            return Ok(festa);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(CalendariFestes festa)
        {
            _context.Add(festa);
            await _context.SaveChangesAsync();
            return Ok(festa.Id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(CalendariFestes festa)
        {
            _context.Attach(festa).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existeix = await _context.CalendarisFestes.AnyAsync(x => x.Id == id);
            if (!existeix) { return NotFound(); }
            _context.CalendarisFestes.Remove(new CalendariFestes { Id = id });
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
