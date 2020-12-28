using Calendaris.Server.Contextes;
using Calendaris.Shared;
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
    public class TreballadorsController : ControllerBase
    {
        
        private readonly CalendarisDbContext _context;

        public TreballadorsController(CalendarisDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Treballador>>> Get()
        {
            var treballadors = await _context.Treballadors.ToListAsync();
            return Ok(treballadors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Treballador>> Get(int id)
        {
            var festa = await _context.Treballadors.FirstOrDefaultAsync(f => f.Id == id);
            return Ok(festa);
        }
    }
}
