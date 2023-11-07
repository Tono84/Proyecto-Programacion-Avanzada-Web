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
    public class TipoRutinaController : ControllerBase
    {
        private readonly MenteCuerpoDbContext _context;

        public TipoRutinaController(MenteCuerpoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoRutinas>>> GetTipoRutinas()
        {
            return await _context.TipoRutinas.ToListAsync();
         }

    [HttpGet("{id}")]
    public async Task<ActionResult<TipoRutinas>> GetTipoRutina(int id)
    {
        var tipoRutina = await _context.TipoRutinas.FindAsync(id);

        if (tipoRutina == null)
        {
            return NotFound();
        }

        return tipoRutina;
    }

    [HttpPost]
    public async Task<ActionResult<TipoRutinas>> PostTipoRutina(TipoRutinas tipoRutina)
    {
        _context.TipoRutinas.Add(tipoRutina);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetTipoRutina", new { id = tipoRutina.IdTipoRutina }, tipoRutina);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutTipoRutina(int id, TipoRutinas tipoRutina)
    {
        if (id != tipoRutina.IdTipoRutina)
        {
            return BadRequest();
        }

        _context.Entry(tipoRutina).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TipoRutinaExists(id))
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
    public async Task<IActionResult> DeleteTipoRutina(int id)
    {
        var tipoRutina = await _context.TipoRutinas.FindAsync(id);
        if (tipoRutina == null)
        {
            return NotFound();
        }

        _context.TipoRutinas.Remove(tipoRutina);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TipoRutinaExists(int id)
    {
        return _context.TipoRutinas.Any(e => e.IdTipoRutina == id);
    }
}
}
