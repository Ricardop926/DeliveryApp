using Delivery.Core.DTOs;
using Delivery.Core.Entities;
using Delivery.Core.Interfaces;
using Delivery.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Infrastructure.Respositories
{
    public class TblClienteRepository : ITblClienteRepository
    {
        private readonly DB_MafiaTechContext _context;

        public TblClienteRepository(DB_MafiaTechContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblCliente>> GetTblClientes()
        {
            var _tblCliente = await _context.TblClientes.ToListAsync();
            return _tblCliente;
        }
        public async Task<TblCliente> GetTblCliente(int id)
        {
            var _tblCliente = await _context.TblClientes.FirstOrDefaultAsync(x => x.IdCliente == id);
            return _tblCliente;

        }
        public async Task InsertTblCliente(TblCliente _tblCliente)
        {
            _context.TblClientes.Add(_tblCliente);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateTblCliente(TblCliente obj)
        {
            _context.TblClientes.Update(obj);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteTblCliente(int id)

        {
            var clienteExistente = _context.TblClientes.FirstOrDefault(x => x.IdCliente == id);
            _context.TblClientes.Remove(clienteExistente);
            await _context.SaveChangesAsync();

        }

    }
}