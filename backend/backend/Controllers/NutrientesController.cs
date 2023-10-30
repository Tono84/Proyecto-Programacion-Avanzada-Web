using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class NutrientesController : ControllerBase
{
    private readonly MenteCuerpoDbContext _context;

    public NutrientesController(MenteCuerpoDbContext context)
    {
        _context = context;
    }

    // GET: api/Nutrientes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Nutriente>>> GetNutrientes()
    {
        return await _context.Nutrientes.ToListAsync();
    }

// GET: api/Nutrientes/5
[HttpGet("{id}")]
public async Task<ActionResult<Nutriente>> GetNutriente(int id)
{
    var nutriente = await _context.Nutrientes.FindAsync(id);

    if (nutriente == null)
    {
        return NotFound();
    }

    return nutriente;
}

// POST: api/Nutrientes
[HttpPost]
public async Task<ActionResult<Nutriente>> PostNutriente(Nutriente nutriente)
{
    _context.Nutrientes.Add(nutriente);
    await _context.SaveChangesAsync();

    return CreatedAtAction("GetNutriente", new { id = nutriente.IdNutriente }, nutriente);
}

// PUT: api/Nutrientes/5
[HttpPut("{id}")]
public async Task<IActionResult> PutNutriente(int id, Nutriente nutriente)
{
    if (id != nutriente.IdNutriente)
    {
        return BadRequest();
    }

    _context.Entry(nutriente).State = EntityState.Modified;

    try
    {
        await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (!NutrienteExists(id))
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

// DELETE: api/Nutrientes/5
[HttpDelete("{id}")]
public async Task<IActionResult> DeleteNutriente(int id)
{
    var nutriente = await _context.Nutrientes.FindAsync(id);
    if (nutriente == null)
    {
        return NotFound();
    }

    _context.Nutrientes.Remove(nutriente);
    await _context.SaveChangesAsync();

    return NoContent();
}

private bool NutrienteExists(int id)
{
    return _context.Nutrientes.Any(e => e.IdNutriente == id);
}
}
