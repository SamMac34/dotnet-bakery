using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DotnetBakery.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetBakery.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BakersController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public BakersController(ApplicationContext context) {
            _context = context;
        }

        // GET route for all Bakers
        [HttpGet]
        public IEnumerable<Baker> GetBakers()
        {
            // Look ma, no SQL
            return _context.Bakers;
        }
// POST /api/bakers
// Note that .NET parses our JSON request for us
// and converts it to a "Baker" model object.
        [HttpPost]
        public IActionResult CreateBaker(Baker baker) 
        {
            _context.Add(baker); // INSERT
            _context.SaveChanges(); // COMMIT

            // This is like the 201 code getting sent back, thing was created
            return CreatedAtAction(nameof(CreateBaker), new {id = baker.Id}, baker);
        }
    }
}
