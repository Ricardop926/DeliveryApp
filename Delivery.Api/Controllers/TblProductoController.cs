using Delivery.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Delivery.Infrastructure.Respositories;
namespace Delivery.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblProductoController : ControllerBase
    {
        private readonly ITblProductoRepository _tblProductoRepository;
        public TblProductoController(ITblProductoRepository tblProductoRepository)
        {
            _tblProductoRepository = tblProductoRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetTblProductos()
        {
            var _producto = await _tblProductoRepository.GetTblProductos();
            return Ok(_producto);
        }
    }
}
