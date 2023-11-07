using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjercicioController : ControllerBase
    {
        private readonly MenteCuerpoDbContext _context;

        public EjercicioController(MenteCuerpoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ejercicio>>> GetEjercicios()
        {
            return await _context.Ejercicios.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ejercicio>> GetEjercicio(int id)
        {
            var ejercicio = await _context.Ejercicios.FindAsync(id);

            if (ejercicio == null)
            {
                return NotFound();
            }

            return ejercicio;
        }

        [HttpPost]
        public async Task<ActionResult<Ejercicio>> PostEjercicio(Ejercicio ejercicio)
        {
            _context.Ejercicios.Add(ejercicio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEjercicio", new { id = ejercicio.IdEjercicio }, ejercicio);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEjercicio(int id, Ejercicio ejercicio)
        {
            if (id != ejercicio.IdEjercicio)
            {
                return BadRequest();
            }

            _context.Entry(ejercicio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EjercicioExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEjercicio(int id)
        {
            var ejercicio = await _context.Ejercicios.FindAsync(id);
            if (ejercicio == null)
            {
                return NotFound();
            }

            _context.Ejercicios.Remove(ejercicio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EjercicioExists(int id)
        {
            return _context.Ejercicios.Any(e => e.IdEjercicio == id);
        }
    }
}
