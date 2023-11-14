using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[Route("api/[controller]")]
[ApiController]
public class EjerciciosXUsuarioController : ControllerBase
{
    private readonly MenteCuerpoDbContext _dbContext; 

    public EjerciciosXUsuarioController(MenteCuerpoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<EjerciciosXUsuario>>> GetEjerciciosXUsuario()
    {
        return await _dbContext.EjerciciosXUsuario.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<EjerciciosXUsuario>> GetEjercicioXUsuario(int id)
    {
        var ejercicioXUsuario = await _dbContext.EjerciciosXUsuario.FindAsync(id);

        if (ejercicioXUsuario == null)
        {
            return NotFound();
        }

        return ejercicioXUsuario;
    }

    [HttpPost]
    public async Task<ActionResult<EjerciciosXUsuario>> PostEjercicioXUsuario(EjerciciosXUsuario ejercicioXUsuario)
    {
        _dbContext.EjerciciosXUsuario.Add(ejercicioXUsuario);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetEjercicioXUsuario), new { id = ejercicioXUsuario.IdEjercicioU }, ejercicioXUsuario);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutEjercicioXUsuario(int id, EjerciciosXUsuario ejercicioXUsuario)
    {
        if (id != ejercicioXUsuario.IdEjercicioU)
        {
            return BadRequest();
        }

        _dbContext.Entry(ejercicioXUsuario).State = EntityState.Modified;

        try
        {
            await _dbContext.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!EjercicioXUsuarioExists(id))
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
    public async Task<IActionResult> DeleteEjercicioXUsuario(int id)
    {
        var ejercicioXUsuario = await _dbContext.EjerciciosXUsuario.FindAsync(id);
        if (ejercicioXUsuario == null)
        {
            return NotFound();
        }

        _dbContext.EjerciciosXUsuario.Remove(ejercicioXUsuario);
        await _dbContext.SaveChangesAsync();

        return NoContent();
    }

    private bool EjercicioXUsuarioExists(int id)
    {
        return _dbContext.EjerciciosXUsuario.Any(e => e.IdEjercicioU == id);
    }
}
