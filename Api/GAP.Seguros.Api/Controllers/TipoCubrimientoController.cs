using GAP.Seguros.Data.Models;
using GAP.Seguros.Data.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GAP.Seguros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoCubrimientoController : ControllerBase
    {
        private readonly SegurosDbContext context;
        private readonly ITipoCubrimientoRepository tipoCubrimientoRepository;

        public TipoCubrimientoController(SegurosDbContext context,ITipoCubrimientoRepository tipoCubrimientoRepository   )
        {
            this.context = context;
            this.tipoCubrimientoRepository = tipoCubrimientoRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<TipoCubrimiento>> GetTipoCubrimiento()
        {
            return await tipoCubrimientoRepository.GetAll();
        }
    }
}
