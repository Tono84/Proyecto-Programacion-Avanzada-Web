using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class InbodyController : ControllerBase
{
    private readonly MenteCuerpoDbContext _dbContext; 

    public InbodyController(MenteCuerpoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Inbody>>> GetInbody()
    {
        return await _dbContext.Inbody.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Inbody>> GetInbody(int id)
    {
        var inbody = await _dbContext.Inbody.FindAsync(id);

        if (inbody == null)
        {
            return NotFound();
        }

        return inbody;
    }

    [HttpPost]
    public async Task<ActionResult<Inbody>> PostInbody(Inbody inbody)
    {
        _dbContext.Inbody.Add(inbody);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetInbody), new { id = inbody.IdInbody }, inbody);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutInbody(int id, Inbody inbody)
    {
        if (id != inbody.IdInbody)
        {
            return BadRequest();
        }

        _dbContext.Entry(inbody).State = EntityState.Modified;

        try
        {
            await _dbContext.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!InbodyExists(id))
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
    public async Task<IActionResult> DeleteInbody(int id)
    {
        var inbody = await _dbContext.Inbody.FindAsync(id);
        if (inbody == null)
        {
            return NotFound();
        }

        _dbContext.Inbody.Remove(inbody);
        await _dbContext.SaveChangesAsync();

        return NoContent();
    }

    private bool InbodyExists(int id)
    {
        return _dbContext.Inbody.Any(e => e.IdInbody == id);
    }
}
