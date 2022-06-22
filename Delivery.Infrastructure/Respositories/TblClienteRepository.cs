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
            var _tblCliente = await _context.TblClientes.FirstOrDefaultAsync(x => x.TblClienteID == id);
            return _tblCliente;

        }
        public async Task InsertTblCliente(TblCliente _tblCliente)
        {
            _context.TblClientes.Add(_tblCliente);
            await _context.SaveChangesAsync();

        }


        public async Task<bool> UpdateTblCliente(TblCliente _tblCliente)
        {
            var currentTblCliente = await GetTblCliente(_tblCliente.TblClienteID);
            currentTblCliente.Nombre = _tblCliente.Nombre;
            currentTblCliente.Email = _tblCliente.Email;
            currentTblCliente.FechaIngreso = _tblCliente.FechaIngreso;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteTblCliente(int id)
        {
            var currentTblCliente = await GetTblCliente(id);
            _context.TblClientes.Remove(currentTblCliente);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

    }
}