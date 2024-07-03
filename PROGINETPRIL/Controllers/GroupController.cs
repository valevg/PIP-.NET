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
    public class GroupsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GroupsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Groups
        [HttpGet]
        public ActionResult<IEnumerable<Groups>> GetGroups()
        {
            return _context.Groups.ToList();
        }

        // GET: api/Groups/5
        [HttpGet("{id}")]
        public ActionResult<Groups> GetGroup(int id)
        {
            var group = _context.Groups.Find(id);

            if (group == null)
            {
                return NotFound();
            }

            return group;
        }

        // POST: api/Groups
        [HttpPost]
        public ActionResult<Groups> PostGroup(Groups group)
        {
            _context.Groups.Add(group);
            _context.SaveChanges();

            return CreatedAtAction("GetGroup", new { id = group.GroupId }, group);
        }

        // PUT: api/Groups/5
        [HttpPut("{id}")]
        public IActionResult PutGroup(int id, Groups group)
        {
            if (id != group.GroupId)
            {
                return BadRequest();
            }

            _context.Entry(group).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Groups/5
        [HttpDelete("{id}")]
        public IActionResult DeleteGroup(int id)
        {
            var group = _context.Groups.Find(id);
            if (group == null)
            {
                return NotFound();
            }

            _context.Groups.Remove(group);
            _context.SaveChanges();

            return NoContent();
        }
    }
}