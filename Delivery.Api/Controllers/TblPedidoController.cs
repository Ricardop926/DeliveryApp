using Delivery.Core.Entities;
using Delivery.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblPedidoController : ControllerBase
    {
        private readonly ITblPedidoRepository _tblPedidoRepository;
        public TblPedidoController(ITblPedidoRepository tblPedidoRepository)
        {
            _tblPedidoRepository = tblPedidoRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetTblPedidos()
        {
            var _pedido = await _tblPedidoRepository.GetTblPedidos();
            return Ok(_pedido);
        }
        [HttpPost]

        public async Task<IActionResult> Post(TblPedido _pedido)
        {
            await _tblPedidoRepository.AddTblPedido(_pedido);
            return Ok(_pedido);
        }
    }
}
