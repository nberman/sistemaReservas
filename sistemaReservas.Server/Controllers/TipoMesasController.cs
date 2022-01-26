using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistemaReservas.Server.Data;
using sistemaReservas.Server.Models;

namespace sistemaReservas.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoMesasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TipoMesasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TipoMesas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoMesa>>> GetTipoMesa()
        {
            return await _context.TipoMesa.ToListAsync();
        }

        // GET: api/TipoMesas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoMesa>> GetTipoMesa(int id)
        {
            var tipoMesa = await _context.TipoMesa.FindAsync(id);

            if (tipoMesa == null)
            {
                return NotFound();
            }

            return tipoMesa;
        }

        // PUT: api/TipoMesas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoMesa(int id, TipoMesa tipoMesa)
        {
            if (id != tipoMesa.IdTipoMesa)
            {
                return BadRequest();
            }

            _context.Entry(tipoMesa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoMesaExists(id))
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

        // POST: api/TipoMesas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoMesa>> PostTipoMesa(TipoMesa tipoMesa)
        {
            _context.TipoMesa.Add(tipoMesa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoMesa", new { id = tipoMesa.IdTipoMesa }, tipoMesa);
        }

        // DELETE: api/TipoMesas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoMesa(int id)
        {
            var tipoMesa = await _context.TipoMesa.FindAsync(id);
            if (tipoMesa == null)
            {
                return NotFound();
            }

            _context.TipoMesa.Remove(tipoMesa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoMesaExists(int id)
        {
            return _context.TipoMesa.Any(e => e.IdTipoMesa == id);
        }
    }
}
