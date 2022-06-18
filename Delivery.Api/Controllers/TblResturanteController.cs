using Delivery.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblResturanteController : ControllerBase
    {

        private readonly ITblRestauranteRepository _tblRestauranteRepository;
        public TblResturanteController(ITblRestauranteRepository tblRestauranteRepository)
        {
            _tblRestauranteRepository = tblRestauranteRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetTblRestaurantes()
        {
            var _restaurante = await _tblRestauranteRepository.GetTblRestaurantes();
            return Ok(_restaurante);
        }
    }
}
