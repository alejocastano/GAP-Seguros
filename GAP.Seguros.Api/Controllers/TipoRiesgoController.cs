using GAP.Seguros.Data.Models;
using GAP.Seguros.Data.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GAP.Seguros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoRiesgoController : ControllerBase
    {
        private readonly SegurosDbContext _context;
        private readonly ITipoRiesgoRepository tipoRiesgoRepository;

        public TipoRiesgoController(SegurosDbContext context, ITipoRiesgoRepository tipoRiesgoRepository)
        {
            _context = context;
            this.tipoRiesgoRepository = tipoRiesgoRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<TipoRiesgo>> GetTipoRiesgo()
        {
            return await tipoRiesgoRepository.GetAll();
        }

    }
}
