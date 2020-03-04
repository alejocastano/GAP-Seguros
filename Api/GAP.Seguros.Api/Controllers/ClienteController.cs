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
    public class ClienteController : ControllerBase
    {
        private readonly SegurosDbContext _context;
        private readonly IClienteRepository clienteRepository;
        private readonly IClientePolizaRepository clientePolizaRepository;

        public ClienteController(SegurosDbContext context, IClienteRepository clienteRepository, IClientePolizaRepository clientePolizaRepository)
        {
            _context = context;
            this.clienteRepository = clienteRepository;
            this.clientePolizaRepository = clientePolizaRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            return await clienteRepository.GetAll();
        }


        [HttpPost("PostClientePoliza")]
        public async Task<ActionResult<ClientePoliza>> PostPoliza(ClientePoliza poliza)
        {
            await clientePolizaRepository.Add(poliza);
            return Ok();
        }

    }
}

