using Calendaris.Server.Contextes;
using Calendaris.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            //var festes = await _context.CalendarisFestes.ToListAsync();
            //return Ok(festes);
            return await _context.CalendarisFestes.ToListAsync();
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult> Get(int id)
        //{
        //    var festes = await _context.CalendarisFestes.FirstOrDefaultAsync(f=>(int)f.Tipus == id);
        //    return Ok(festes);
        //}

        //[HttpPost]
        //public async Task<ActionResult> Post(CalendariFestes festa)
        //{
        //    _context.Add(festa);
        //    await _context.SaveChangesAsync();
        //    return Ok(festa.Id);
        //}

        //[HttpPut]
        //public async Task<ActionResult> Put(CalendariFestes festa)
        //{
        //    _context.Entry(festa).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}


        //[HttpDelete("{id}")]
        //public async Task<ActionResult> Delete(int id)
        //{
        //    var festa = new CalendariFestes { Id = id };
        //    _context.Remove(festa);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}
    }
}
