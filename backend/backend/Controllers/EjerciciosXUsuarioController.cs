using backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[EnableCors("AllowLocalhost")]
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
    public async Task<ActionResult<List<EjerciciosXUsuario>>> GetEjercicioXUsuario(int id)
    {
        var ejerciciosXUsuarioList = await _dbContext.EjerciciosXUsuario
            .Where(e => e.IdUsuario == id)
            .ToListAsync();

        if (ejerciciosXUsuarioList == null || ejerciciosXUsuarioList.Count == 0)
        {
            return NotFound();
        }

        return ejerciciosXUsuarioList;
    }

    [HttpGet("views/{idUsuario}")]
    public async Task<ActionResult<IEnumerable<EjerciciosXUsuarioView>>> GetEjerciciosXUsuarioView(int idUsuario)
    {
        // Use the new model class for the result
        var result = await _dbContext.EjerciciosXUsuarioView
            .Where(e => e.idUsuario == idUsuario)
            .ToListAsync();

        return Ok(result);
    }


    [HttpPost]
    public async Task<ActionResult<EjerciciosXUsuario>> PostEjercicioXUsuario(EjerciciosXUsuario ejercicioXUsuario)
    {
        Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:7120");
        Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, OPTIONS");
        Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");

        _dbContext.EjerciciosXUsuario.Add(ejercicioXUsuario);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetEjercicioXUsuario), new { id = ejercicioXUsuario.idEjericioU }, ejercicioXUsuario);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutEjercicioXUsuario(int id, EjerciciosXUsuario ejercicioXUsuario)
    {
        if (id != ejercicioXUsuario.idEjericioU)
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
        return _dbContext.EjerciciosXUsuario.Any(e => e.idEjericioU == id);
    }
}
