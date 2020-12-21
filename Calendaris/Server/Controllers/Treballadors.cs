using Calendaris.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendaris.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TreballadorsController : ControllerBase
    {
        
        private readonly ILogger<TreballadorsController> _logger;

        public TreballadorsController(ILogger<TreballadorsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "lalala";
        }
    }
}
