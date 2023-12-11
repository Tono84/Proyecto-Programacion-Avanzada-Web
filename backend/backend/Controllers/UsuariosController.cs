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
    public class UsuarioController : ControllerBase
    {
        private readonly MenteCuerpoDbContext _context;

        public UsuarioController(MenteCuerpoDbContext context)
        {
            _context = context;
        }

        [HttpPost("VerificarUsuario")]
        public async Task<ActionResult<object>> VerificarUsuario([FromBody] VerificacionUsuario request)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.NombreUsuario == request.Username && u.Contraseña == request.Password);

            if (usuario != null)
            {
                return Ok(usuario);
            }

            return NotFound(false);
        }


        [HttpGet("{id}")]
    public async Task<ActionResult<Usuario>> GetUsuario(int id)
    {
        var usuario = await _context.Usuarios.FindAsync(id);

        if (usuario == null)
        {
            return NotFound();
        }

        return usuario;
    }

    [HttpPost]
    public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetUsuario", new { id = usuario.IdUsuario }, usuario);
    }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.IdUsuario)
            {
                return BadRequest();
            }

            var existingUsuario = await _context.Usuarios.FindAsync(id);

            if (existingUsuario == null)
            {
                return NotFound();
            }

            // Update only the fields that are not null in the provided 'usuario' object
            if (usuario.Nombre != null)
            {
                existingUsuario.Nombre = usuario.Nombre;
            }

            if (usuario.Apellido != null)
            {
                existingUsuario.Apellido = usuario.Apellido;
            }

            if (usuario.Correo != null)
            {
                existingUsuario.Correo = usuario.Correo;
            }

            if (usuario.Contraseña != null)
            {
                existingUsuario.Contraseña = usuario.Contraseña;
            }

            if (usuario.membresiaID != null)
            {
                existingUsuario.membresiaID = usuario.membresiaID;
            }

            _context.Entry(existingUsuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
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
    public async Task<IActionResult> DeleteUsuario(int id)
    {
        var usuario = await _context.Usuarios.FindAsync(id);
        if (usuario == null)
        {
            return NotFound();
        }

        _context.Usuarios.Remove(usuario);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool UsuarioExists(int id)
    {
        return _context.Usuarios.Any(e => e.IdUsuario == id);
    }

}
}
