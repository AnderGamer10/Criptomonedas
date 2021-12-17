using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Criptomonedas.Models;

namespace Criptomonedas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CriptoItemsController : ControllerBase
    {
        private readonly CriptoContext _context;

        public CriptoItemsController(CriptoContext context)
        {
            _context = context;
        }

        // GET: api/CriptoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CriptoItems>>> GetCriptoItems()
        {
            foreach (var i in _context.CriptoItems.ToList())
            {
                var ran = new Random();
                i.ValorActual = (decimal)new Random().NextDouble() * 100000;
                if (i.ValorMaximo < i.ValorActual)
                {
                    i.ValorMaximo = i.ValorActual;
                }
            }
            _context.SaveChanges();

            return await _context.CriptoItems.ToListAsync();
        }

        // GET: api/CriptoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CriptoItems>> GetCriptoItems(string id)
        {
            var criptoItems = await _context.CriptoItems.FindAsync(id);

            if (criptoItems == null)
            {
                return NotFound();
            }
            else
            {
                criptoItems.ValorActual = (decimal)new Random().NextDouble() * 100000;
                if (criptoItems.ValorMaximo < criptoItems.ValorActual)
                {
                    criptoItems.ValorMaximo = criptoItems.ValorActual;
                }
            }
            _context.SaveChanges();


            return criptoItems;
        }

        // PUT: api/CriptoItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCriptoItems(string id, CriptoItems criptoItems)
        {
            if (id != criptoItems.Nombre)
            {
                return BadRequest();
            }

            _context.Entry(criptoItems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CriptoItemsExists(id))
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

        // POST: api/CriptoItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CriptoItems>> PostCriptoItems(CriptoItems criptoItems)
        {
            _context.CriptoItems.Add(criptoItems);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CriptoItemsExists(criptoItems.Nombre))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCriptoItems", new { id = criptoItems.Nombre }, criptoItems);
        }

        // DELETE: api/CriptoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCriptoItems(string id)
        {
            var criptoItems = await _context.CriptoItems.FindAsync(id);
            if (criptoItems == null)
            {
                return NotFound();
            }

            _context.CriptoItems.Remove(criptoItems);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CriptoItemsExists(string id)
        {
            return _context.CriptoItems.Any(e => e.Nombre == id);
        }
    }
}
