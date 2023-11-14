using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[Route("api/[controller]")]
[ApiController]
public class MembresiasController : ControllerBase
{
    private readonly MenteCuerpoDbContext _dbContext; 

    public MembresiasController(MenteCuerpoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Membresia>>> GetMembresias()
    {
        return await _dbContext.Membresias.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Membresia>> GetMembresia(int id)
    {
        var membresia = await _dbContext.Membresias.FindAsync(id);

        if (membresia == null)
        {
            return NotFound();
        }

        return membresia;
    }

    [HttpPost]
    public async Task<ActionResult<Membresia>> PostMembresia(Membresia membresia)
    {
        _dbContext.Membresias.Add(membresia);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetMembresia), new { id = membresia.IdMembresia }, membresia);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutMembresia(int id, Membresia membresia)
    {
        if (id != membresia.IdMembresia)
        {
            return BadRequest();
        }

        _dbContext.Entry(membresia).State = EntityState.Modified;

        try
        {
            await _dbContext.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!MembresiaExists(id))
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
    public async Task<IActionResult> DeleteMembresia(int id)
    {
        var membresia = await _dbContext.Membresias.FindAsync(id);
        if (membresia == null)
        {
            return NotFound();
        }

        _dbContext.Membresias.Remove(membresia);
        await _dbContext.SaveChangesAsync();

        return NoContent();
    }

    private bool MembresiaExists(int id)
    {
        return _dbContext.Membresias.Any(e => e.IdMembresia == id);
    }
}
