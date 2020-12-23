﻿using Calendaris.Server.Contextes;
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
        public async Task<IActionResult> Get()
        {
            var festes = await _context.CalendarisFestes.ToListAsync();
            return Ok(festes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var festes = await _context.CalendarisFestes.FirstOrDefaultAsync(f=>(int)f.Tipus == id);
            return Ok(festes);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CalendariFestes festa)
        {
            _context.Add(festa);
            await _context.SaveChangesAsync();
            return Ok(festa.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(CalendariFestes festa)
        {
            _context.Entry(festa).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var festa = new CalendariFestes { Id = id };
            _context.Remove(festa);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}