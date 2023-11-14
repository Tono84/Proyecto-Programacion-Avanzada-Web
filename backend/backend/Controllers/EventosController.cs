using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class EventosController : ControllerBase
{
    private readonly MenteCuerpoDbContext _dbContext; 

    public EventosController(MenteCuerpoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Evento>>> GetEventos()
    {
        return await _dbContext.Eventos.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Evento>> GetEvento(int id)
    {
        var evento = await _dbContext.Eventos.FindAsync(id);

        if (evento == null)
        {
            return NotFound();
        }

        return evento;
    }

    [HttpPost]
    public async Task<ActionResult<Evento>> PostEvento(Evento evento)
    {
        _dbContext.Eventos.Add(evento);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetEvento), new { id = evento.IdEvento }, evento);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutEvento(int id, Evento evento)
    {
        if (id != evento.IdEvento)
        {
            return BadRequest();
        }

        _dbContext.Entry(evento).State = EntityState.Modified;

        try
        {
            await _dbContext.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!EventoExists(id))
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
    public async Task<IActionResult> DeleteEvento(int id)
    {
        var evento = await _dbContext.Eventos.FindAsync(id);
        if (evento == null)
        {
            return NotFound();
        }

        _dbContext.Eventos.Remove(evento);
        await _dbContext.SaveChangesAsync();

        return NoContent();
    }

    private bool EventoExists(int id)
    {
        return _dbContext.Eventos.Any(e => e.IdEvento == id);
    }
}
