using Delivery.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


using Delivery.Infrastructure.Respositories;
using Delivery.Core.Entities;
using AutoMapper;
using Delivery.Core.DTOs;

namespace Delivery.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblClienteController : ControllerBase
    {
        private readonly ITblClienteRepository _tblClienteRepository;
        private readonly IMapper _mapper;
        public TblClienteController(IMapper mapper, ITblClienteRepository tblClienteRepository)
        {
            _tblClienteRepository = tblClienteRepository;
            _mapper = mapper;

        }
        [HttpGet]
        public async Task<IActionResult> GetTblClientes()
        {
            var _cliente = await _tblClienteRepository.GetTblClientes();
            var _clienteDto = _mapper.Map<IEnumerable<TblClienteDto>>(_cliente);
            return Ok(_clienteDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTblCliente(int id)
        {
            var _cliente = await _tblClienteRepository.GetTblCliente(id);
            var _clienteDto = _mapper.Map<TblClienteDto>(_cliente);
            return Ok(_clienteDto);
        }

        [HttpPost]
         public async Task<IActionResult> Post(TblClienteDto _clienteDto)
        {
            var _cliente = _mapper.Map<TblCliente>(_clienteDto);
            await _tblClienteRepository.InsertTblCliente(_cliente);
            return Ok(_cliente);
        }

       [HttpPut]
        public async Task<IActionResult> Put(int id, TblClienteDto _clienteDto)
        {
            var _cliente = _mapper.Map<TblCliente>(_clienteDto);
            await _tblClienteRepository.UpdateTblCliente(_cliente);
            return Ok(_cliente);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _tblClienteRepository.DeleteTblCliente(id);

            return Ok(result);
        }



    }   
    
    
    

}
