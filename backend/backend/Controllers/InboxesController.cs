using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class InboxController : ControllerBase
{
    private readonly MenteCuerpoDbContext _dbContext; 

    public InboxController(MenteCuerpoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Inbox>>> GetInbox()
    {
        return await _dbContext.Inbox.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Inbox>> GetInbox(int id)
    {
        var inbox = await _dbContext.Inbox.FindAsync(id);

        if (inbox == null)
        {
            return NotFound();
        }

        return inbox;
    }

    [HttpPost]
    public async Task<ActionResult<Inbox>> PostInbox(Inbox inbox)
    {
        _dbContext.Inbox.Add(inbox);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetInbox), new { id = inbox.IdInbox }, inbox);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutInbox(int id, Inbox inbox)
    {
        if (id != inbox.IdInbox)
        {
            return BadRequest();
        }

        _dbContext.Entry(inbox).State = EntityState.Modified;

        try
        {
            await _dbContext.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!InboxExists(id))
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
    public async Task<IActionResult> DeleteInbox(int id)
    {
        var inbox = await _dbContext.Inbox.FindAsync(id);
        if (inbox == null)
        {
            return NotFound();
        }

        _dbContext.Inbox.Remove(inbox);
        await _dbContext.SaveChangesAsync();

        return NoContent();
    }

    private bool InboxExists(int id)
    {
        return _dbContext.Inbox.Any(e => e.IdInbox == id);
    }
}
