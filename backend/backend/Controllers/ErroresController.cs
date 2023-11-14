using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ErroresController : ControllerBase
{
    private readonly MenteCuerpoDbContext _dbContext; 

    public ErroresController(MenteCuerpoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Error>>> GetErrores()
    {
        return await _dbContext.Errores.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Error>> GetError(int id)
    {
        var error = await _dbContext.Errores.FindAsync(id);

        if (error == null)
        {
            return NotFound();
        }

        return error;
    }

    [HttpPost]
    public async Task<ActionResult<Error>> PostError(Error error)
    {
        _dbContext.Errores.Add(error);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetError), new { id = error.IdError }, error);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutError(int id, Error error)
    {
        if (id != error.IdError)
        {
            return BadRequest();
        }

        _dbContext.Entry(error).State = EntityState.Modified;

        try
        {
            await _dbContext.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ErrorExists(id))
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
    public async Task<IActionResult> DeleteError(int id)
    {
        var error = await _dbContext.Errores.FindAsync(id);
        if (error == null)
        {
            return NotFound();
        }

        _dbContext.Errores.Remove(error);
        await _dbContext.SaveChangesAsync();

        return NoContent();
    }

    private bool ErrorExists(int id)
    {
        return _dbContext.Errores.Any(e => e.IdError == id);
    }
}
