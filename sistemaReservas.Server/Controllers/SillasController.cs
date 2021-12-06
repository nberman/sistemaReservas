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
    public class SillasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SillasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Sillas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Silla>>> GetSillas()
        {
            return await _context.Sillas.ToListAsync();
        }

        // GET: api/Sillas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Silla>> GetSilla(int id)
        {
            var silla = await _context.Sillas.FindAsync(id);

            if (silla == null)
            {
                return NotFound();
            }

            return silla;
        }

        // PUT: api/Sillas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSilla(int id, Silla silla)
        {
            if (id != silla.IdSilla)
            {
                return BadRequest();
            }

            _context.Entry(silla).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SillaExists(id))
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

        // POST: api/Sillas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Silla>> PostSilla(Silla silla)
        {
            _context.Sillas.Add(silla);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSilla", new { id = silla.IdSilla }, silla);
        }

        // DELETE: api/Sillas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSilla(int id)
        {
            var silla = await _context.Sillas.FindAsync(id);
            if (silla == null)
            {
                return NotFound();
            }

            _context.Sillas.Remove(silla);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SillaExists(int id)
        {
            return _context.Sillas.Any(e => e.IdSilla == id);
        }
    }
}
