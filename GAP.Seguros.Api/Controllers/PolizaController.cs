using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GAP.Seguros.Data.Models;
using GAP.Seguros.Data.Repository.Interfaces;

namespace GAP.Seguros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizaController : ControllerBase
    {
        private readonly SegurosDbContext _context;
        private readonly IPolizaRepository polizaRepository;

        public PolizaController(SegurosDbContext context,IPolizaRepository polizaRepository)
        {
            _context = context;
            this.polizaRepository = polizaRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Poliza>> GetPoliza()
        {
            return await polizaRepository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Poliza>> GetPoliza(int id)
        {
            var poliza = await polizaRepository.Get(id);

            if (poliza == null)
            {
                return NotFound();
            }

            return poliza;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPoliza(int id, Poliza poliza)
        {
            if (id != poliza.IdPoliza)
            {
                return BadRequest();
            }

            try
            {
                await polizaRepository.Update(poliza);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PolizaExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Poliza>> PostPoliza(Poliza poliza)
        {
            await polizaRepository.Add(poliza);
            return CreatedAtAction("PostPoliza", new { id = poliza.IdPoliza }, poliza);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Poliza>> DeletePoliza(int id)
        {
            var poliza = await polizaRepository.Get(id);
            if (poliza == null)
            {
                return NotFound();
            }

            await polizaRepository.Delete(poliza);

            return poliza;
        }

        private bool PolizaExists(int id)
        {
            return _context.Poliza.Any(e => e.IdPoliza == id);
        }
    }
}
