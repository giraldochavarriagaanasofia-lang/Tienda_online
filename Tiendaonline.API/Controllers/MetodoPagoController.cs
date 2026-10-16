
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tiendaonline.API.Data;
using Tiendaonline.API.Models;

namespace Tiendaonline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetodoPagoController : ControllerBase
    {
        private readonly TiendaonlineDbContext _context;

        public MetodoPagoController(TiendaonlineDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MetodoPago>>> GetMetodosPago()
        {
            return await _context.MetodosPago.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MetodoPago>> GetMetodoPago(int id)
        {
            var metodo = await _context.MetodosPago.FindAsync(id);

            if (metodo == null)
                return NotFound();

            return metodo;
        }

        [HttpPost]
        public async Task<ActionResult<MetodoPago>> PostMetodoPago(MetodoPago metodo)
        {
            _context.MetodosPago.Add(metodo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetMetodoPago),
                new { id = metodo.IdMetodoPago },
                metodo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMetodoPago(int id, MetodoPago metodo)
        {
            if (id != metodo.IdMetodoPago)
                return BadRequest();

            _context.Entry(metodo).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMetodoPago(int id)
        {
            var metodo = await _context.MetodosPago.FindAsync(id);

            if (metodo == null)
                return NotFound();

            _context.MetodosPago.Remove(metodo);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}