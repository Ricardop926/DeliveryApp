using AutoMapper;
using Delivery.Core.DTOs;
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
        private readonly IMapper _mapper;
        public TblDetallepedidoController(IMapper mapper, ITblDetallepedidoRepository tblDetallepedidoRepository)
        {
            _tblDetallepedidoRepository = tblDetallepedidoRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetTblDetallepedidos()
        {
            var _Detallepedido = await _tblDetallepedidoRepository.GetTblDetallepedidos();
            var _DetallepeidoDto = _mapper.Map<IEnumerable<TblClienteDto>>(_Detallepedido);
            return Ok(_DetallepeidoDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTblDetallepedido(int id)
        {
            var _Detallepedido = await _tblDetallepedidoRepository.GetTblDetallepedido(id);
            var _DetallepedidoDto = _mapper.Map<TblDetallepedido>(_Detallepedido);
            return Ok(_DetallepedidoDto);
        }

        [HttpPost]

        public async Task<IActionResult> Post(TblDetallepedido _Detallepedido)
        {
            await _tblDetallepedidoRepository.AddTblDetallepedido(_Detallepedido);
            return Ok(_Detallepedido);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, TblDetallepedidoDto _DetallepeidoDto)
        {
            var _Detallepedido = _mapper.Map<TblDetallepedido>(_DetallepeidoDto);
            await _tblDetallepedidoRepository.UpdateTblDetallepedido(_Detallepedido);
            return Ok(_Detallepedido);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _tblDetallepedidoRepository.DeleteTblDetallepedido(id);

            return Ok(result);
        }


    }
}
