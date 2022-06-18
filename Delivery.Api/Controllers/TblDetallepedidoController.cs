using Delivery.Core.Entities;
using Delivery.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblDetallepedidoController : ControllerBase
    {

        private readonly ITblDetallepedidoRepository _tblDetallepedidoRepository;
        public TblDetallepedidoController(ITblDetallepedidoRepository tblDetallepedidoRepository)
        {
            _tblDetallepedidoRepository = tblDetallepedidoRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetTblDetallepedidos()
        {
            var _Detallepedido = await _tblDetallepedidoRepository.GetTblDetallepedidos();
            return Ok(_Detallepedido);
        }

        [HttpPost]

        public async Task<IActionResult> Post(TblDetallepedido _Detallepedido)
        {
            await _tblDetallepedidoRepository.AddTblDetallepedido(_Detallepedido);
            return Ok(_Detallepedido);
        }


    }
}
