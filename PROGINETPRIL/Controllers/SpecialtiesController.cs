using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROGINETPRIL.Models;
using PROGINETPRIL.Data;
using System.Collections.Generic;
using System.Linq;

namespace PROGINETPRIL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialtiesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SpecialtiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Specialties
        [HttpGet]
        public ActionResult<IEnumerable<Specialties>> GetSpecialties()
        {
            return _context.Specialties.ToList();
        }

        // GET: api/Specialties/5
        [HttpGet("{id}")]
        public ActionResult<Specialties> GetSpecialties(int id)
        {
            var specialties = _context.Specialties.Find(id);

            if (specialties == null)
            {
                return NotFound();
            }

            return specialties;
        }

        // POST: api/Specialties
        [HttpPost]
        public ActionResult<Specialties> PostSpecialties(Specialties specialties)
        {
            _context.Specialties.Add(specialties);
            _context.SaveChanges();

            return CreatedAtAction("GetSpecialties", new { id = specialties.SpecialtyId }, specialties);
        }

        // PUT: api/Specialties/5
        [HttpPut("{id}")]
        public IActionResult PutSpecialties(int id, Specialties specialties)
        {
            if (id != specialties.SpecialtyId)
            {
                return BadRequest();
            }

            _context.Entry(specialties).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Specialties/5
        [HttpDelete("{id}")]
        public IActionResult DeleteSpecialties(int id)
        {
            var specialties = _context.Specialties.Find(id);
            if (specialties == null)
            {
                return NotFound();
            }

            _context.Specialties.Remove(specialties);
            _context.SaveChanges();

            return NoContent();
        }
    }
}