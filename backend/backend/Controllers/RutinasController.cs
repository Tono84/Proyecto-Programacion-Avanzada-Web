using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Models;

[Route("api/[controller]")]
[ApiController]
public class RutinaController : ControllerBase
{
    private readonly MenteCuerpoDbContext _context;

    public RutinaController(MenteCuerpoDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Rutina>>> GetRutinas()
    {
        return await _context.Rutinas.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Rutina>> GetRutina(int id)
    {
        var rutina = await _context.Rutinas.FindAsync(id);

        if (rutina == null)
        {
            return NotFound();
        }

        return rutina;
    }

    [HttpPost]
    public async Task<ActionResult<Rutina>> PostRutina(Rutina rutina)
    {
        _context.Rutinas.Add(rutina);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetRutina", new { id = rutina.IdRutina }, rutina);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutRutina(int id, Rutina rutina)
    {
        if (id != rutina.IdRutina)
        {
            return BadRequest();
        }

        _context.Entry(rutina).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!RutinaExists(id))
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
    public async Task<ActionResult<Rutina>> DeleteRutina(int id)
    {
        var rutina = await _context.Rutinas.FindAsync(id);
        if (rutina == null)
        {
            return NotFound();
        }

        _context.Rutinas.Remove(rutina);
        await _context.SaveChangesAsync();

        return rutina;
    }

    private bool RutinaExists(int id)
    {
        return _context.Rutinas.Any(e => e.IdRutina == id);
    }
}
