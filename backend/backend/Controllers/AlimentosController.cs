using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class AlimentosController : ControllerBase
{
    private readonly MenteCuerpoDbContext _context;

    public AlimentosController(MenteCuerpoDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Alimento>>> GetAlimentos()
    {
        return await _context.Alimentos.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Alimento>> GetAlimento(int id)
    {
        var alimento = await _context.Alimentos.FindAsync(id);

        if (alimento == null)
        {
            return NotFound();
        }

        return alimento;
    }

    [HttpPost]
    public async Task<ActionResult<Alimento>> PostAlimento(Alimento alimento)
    {
        _context.Alimentos.Add(alimento);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetAlimento", new { id = alimento.IdAlimento }, alimento);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAlimento(int id, Alimento alimento)
    {
        if (id != alimento.IdAlimento)
        {
            return BadRequest();
        }

        _context.Entry(alimento).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!AlimentoExists(id))
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
    public async Task<IActionResult> DeleteAlimento(int id)
    {
        var alimento = await _context.Alimentos.FindAsync(id);
        if (alimento == null)
        {
            return NotFound();
        }

        _context.Alimentos.Remove(alimento);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool AlimentoExists(int id)
    {
        return _context.Alimentos.Any(e => e.IdAlimento == id);
    }
}
