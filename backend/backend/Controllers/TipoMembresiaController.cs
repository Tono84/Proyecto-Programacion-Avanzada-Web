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
    public class TipoMembresiaController : ControllerBase
    {
        private readonly MenteCuerpoDbContext _context;

        public TipoMembresiaController(MenteCuerpoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoMembresia>>> GetTipoMembresias()
        {
            return await _context.TipoMembresias.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TipoMembresia>> GetTipoMembresia(int id)
    {
        var tipoMembresia = await _context.TipoMembresias.FindAsync(id);

        if (tipoMembresia == null)
        {
            return NotFound();
        }

        return tipoMembresia;
    }

    [HttpPost]
    public async Task<ActionResult<TipoMembresia>> PostTipoMembresia(TipoMembresia tipoMembresia)
    {
        _context.TipoMembresias.Add(tipoMembresia);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetTipoMembresia", new { id = tipoMembresia.IdTipoMembresia }, tipoMembresia);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutTipoMembresia(int id, TipoMembresia tipoMembresia)
    {
        if (id != tipoMembresia.IdTipoMembresia)
        {
            return BadRequest();
        }

        _context.Entry(tipoMembresia).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TipoMembresiaExists(id))
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
    public async Task<IActionResult> DeleteTipoMembresia(int id)
    {
        var tipoMembresia = await _context.TipoMembresias.FindAsync(id);
        if (tipoMembresia == null)
        {
            return NotFound();
        }

        _context.TipoMembresias.Remove(tipoMembresia);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TipoMembresiaExists(int id)
    {
        return _context.TipoMembresias.Any(e => e.IdTipoMembresia == id);
    }
}
}
