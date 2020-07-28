using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TBC_API.Data;
using TBC_API.Models;

namespace TBC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PPersonsController : ControllerBase
    {
        private readonly DataContext _context;

        public PPersonsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/PPersons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PPerson>>> GetPPerson()
        {
            return await _context.PPerson.ToListAsync();
        }

        // GET: api/PPersons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PPerson>> GetPPerson(int id)
        {
            var pPerson = await _context.PPerson.FindAsync(id);

            if (pPerson == null)
            {
                return NotFound();
            }

            return pPerson;
        }

        // PUT: api/PPersons/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPPerson(int id, PPerson pPerson)
        {
            if (id != pPerson.Id)
            {
                return BadRequest();
            }

            _context.Entry(pPerson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PPersonExists(id))
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

        // POST: api/PPersons
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<PPerson>> PostPPerson(PPerson pPerson)
        {
            _context.PPerson.Add(pPerson);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPPerson", new { id = pPerson.Id }, pPerson);
        }

        // DELETE: api/PPersons/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PPerson>> DeletePPerson(int id)
        {
            var pPerson = await _context.PPerson.FindAsync(id);
            if (pPerson == null)
            {
                return NotFound();
            }

            _context.PPerson.Remove(pPerson);
            await _context.SaveChangesAsync();

            return pPerson;
        }

        private bool PPersonExists(int id)
        {
            return _context.PPerson.Any(e => e.Id == id);
        }
    }
}
