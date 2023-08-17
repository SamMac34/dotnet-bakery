using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotnetBakery.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace DotnetBakery.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BreadsController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public BreadsController(ApplicationContext context) {
            _context = context;
        }
        
        [HttpGet]
        public IEnumerable<Bread> GetBreads()
        {
            return _context.Breads
            .Include(breads => breads.BakedBy);
        }

        //  /:id
        [HttpDelete("{id}")]
        public IActionResult DeleteBread(int id)
        {
            Bread bread = _context.Breads.Find(id);
            _context.Breads.Remove(bread);
            _context.SaveChanges();

            return Ok(); // 200
        }
        
        // /:id
        [HttpPut("{id}")]
        public Bread Put(int id, Bread bread)
        {
            // Need to make sure out id is on bread
            bread.Id = id;

            _context.Update(bread);
            _context.SaveChanges();

            return bread;
        }

    }
}
