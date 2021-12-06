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
    public class TipoSillasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TipoSillasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TipoSillas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoSilla>>> GetTiposSilla()
        {
            return await _context.TiposSilla.ToListAsync();
        }

        // GET: api/TipoSillas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoSilla>> GetTipoSilla(int id)
        {
            var tipoSilla = await _context.TiposSilla.FindAsync(id);

            if (tipoSilla == null)
            {
                return NotFound();
            }

            return tipoSilla;
        }

        // PUT: api/TipoSillas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoSilla(int id, TipoSilla tipoSilla)
        {
            if (id != tipoSilla.IdTipoSilla)
            {
                return BadRequest();
            }

            _context.Entry(tipoSilla).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoSillaExists(id))
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

        // POST: api/TipoSillas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoSilla>> PostTipoSilla(TipoSilla tipoSilla)
        {
            _context.TiposSilla.Add(tipoSilla);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoSilla", new { id = tipoSilla.IdTipoSilla }, tipoSilla);
        }

        // DELETE: api/TipoSillas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoSilla(int id)
        {
            var tipoSilla = await _context.TiposSilla.FindAsync(id);
            if (tipoSilla == null)
            {
                return NotFound();
            }

            _context.TiposSilla.Remove(tipoSilla);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoSillaExists(int id)
        {
            return _context.TiposSilla.Any(e => e.IdTipoSilla == id);
        }
    }
}
