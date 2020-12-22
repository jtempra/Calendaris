using Calendaris.Server.Contextes;
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
    [Route("[controller]")]
    public class FestesController : ControllerBase
    {

        private readonly ILogger<FestesController> _logger;
        private readonly CalendarisDbContext _context;

        public FestesController(ILogger<FestesController> logger, CalendarisDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var festes = await _context.CalendarisFestes.ToListAsync();
            return Ok(festes);
        }
    }
}
