using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GAP.Seguros.Data.Models;
using GAP.Seguros.Data.Repository.Interfaces;
using GAP.Seguros.Business;
using System.Net;

namespace GAP.Seguros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizaController : ControllerBase
    {
        private readonly SegurosDbContext _context;
        private readonly IPolizaRepository polizaRepository;
        private PolizasBL polizasbl;
        public PolizaController(SegurosDbContext context,IPolizaRepository polizaRepository)
        {
            _context = context;
            this.polizaRepository = polizaRepository;
            this.polizasbl = new PolizasBL();
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
                ValidationResult result = polizasbl.ValidarRiesgoPoliza(poliza);
                if (result.valido)
                {
                    await polizaRepository.Update(poliza);
                }
                else
                {
                    return StatusCode((int)HttpStatusCode.Forbidden, result.mensaje);

                }
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
            catch(Exception exc)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Poliza>> PostPoliza(Poliza poliza)
        {
            ValidationResult result = polizasbl.ValidarRiesgoPoliza(poliza);
            if (result.valido)
            {
                await polizaRepository.Add(poliza);
                return CreatedAtAction("PostPoliza", new { id = poliza.IdPoliza }, poliza);
            }
            else
            {
                return StatusCode((int)HttpStatusCode.Forbidden, result.mensaje);
            }
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
