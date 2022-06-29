using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RainbowStudent;

namespace RainbowStudent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRainsController : ControllerBase
    {
        private readonly StudentDBContext _context;

        public StudentRainsController(StudentDBContext context)
        {
            _context = context;
        }

        // GET: api/StudentRains
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentRain>>> GetStudent()
        {
            return await _context.Student.ToListAsync();
        }

        // GET: api/StudentRains/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentRain>> GetStudentRain(int id)
        {
            var studentRain = await _context.Student.FindAsync(id);

            if (studentRain == null)
            {
                return NotFound();
            }

            return studentRain;
        }

        // PUT: api/StudentRains/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentRain(int id, StudentRain studentRain)
        {
            if (id != studentRain.ID)
            {
                return BadRequest();
            }

            _context.Entry(studentRain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentRainExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/StudentRains
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StudentRain>> PostStudentRain(StudentRain studentRain)
        {
            _context.Student.Add(studentRain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudentRain", new { id = studentRain.ID }, studentRain);
        }

        // DELETE: api/StudentRains/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentRain(int id)
        {
            var studentRain = await _context.Student.FindAsync(id);
            if (studentRain == null)
            {
                return NotFound();
            }

            _context.Student.Remove(studentRain);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentRainExists(int id)
        {
            return _context.Student.Any(e => e.ID == id);
        }
    }
}
