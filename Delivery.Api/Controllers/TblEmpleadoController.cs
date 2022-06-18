using Delivery.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblEmpleadoController : ControllerBase
    {

        private readonly ITblEmpleadoRepository _tblEmpleadoRepository;
        public TblEmpleadoController(ITblEmpleadoRepository tblEmpleadoRepository)
        {
            _tblEmpleadoRepository = tblEmpleadoRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetTblEmpleados()
        {
            var _pedido = await _tblEmpleadoRepository.GetTblEmpleados();
            return Ok(_pedido);
        }
    }
}
