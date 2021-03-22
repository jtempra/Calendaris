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
    public class ConvenisController : ControllerBase
    {

        private readonly CalendarisDbContext _context;

        public ConvenisController(CalendarisDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Conveni>>> Get()
        {
            var convenis = await _context.Convenis.ToListAsync();
            return Ok(convenis);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Conveni>> Get(int id)
        {
            var conveni = await _context.Convenis.FirstOrDefaultAsync(c => c.Id == id);
            return Ok(conveni);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Conveni conveni)
        {
            _context.Add(conveni);
            await _context.SaveChangesAsync();
            return Ok(conveni.Id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Conveni conveni)
        {
            _context.Attach(conveni).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existeix = await _context.Convenis.AnyAsync(c => c.Id == id);
            if (!existeix) { return NotFound(); }
            _context.Convenis.Remove(new Conveni { Id = id });
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
