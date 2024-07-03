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
    public class TeacherController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TeacherController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Teachers
        [HttpGet]
        public ActionResult<IEnumerable<Teachers>> GetTeachers()
        {
            return _context.Teachers.ToList();
        }

        // GET: api/Teachers/5
        [HttpGet("{id}")]
        public ActionResult<Teachers> GetTeacher(int id)
        {
            var teacher = _context.Teachers.Find(id);

            if (teacher == null)
            {
                return NotFound();
            }

            return teacher;
        }

        // POST: api/Teachers
        [HttpPost]
        public ActionResult<Teachers> PostTeacher(Teachers teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();

            return CreatedAtAction("GetTeacher", new { id = teacher.Id }, teacher);
        }

        // PUT: api/Teachers/5
        [HttpPut("{id}")]
        public IActionResult PutTeacher(int id, Teachers teacher)
        {
            if (id != teacher.Id)
            {
                return BadRequest();
            }

            _context.Entry(teacher).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Teachers/5
        [HttpDelete("{id}")]
        public IActionResult DeleteTeacher(int id)
        {
            var teacher = _context.Teachers.Find(id);
            if (teacher == null)
            {
                return NotFound();
            }

            _context.Teachers.Remove(teacher);
            _context.SaveChanges();

            return NoContent();
        }
    }
}