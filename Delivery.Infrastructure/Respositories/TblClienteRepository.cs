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
        public async Task AddTblCliente(TblCliente obj)
        {
            _context.TblClientes.Add(obj);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateTblCliente(TblCliente obj)
        {
            _context.TblClientes.Update(obj);
            await _context.SaveChangesAsync();

        }
        public async Task DeleteTblCliente(TblCliente obj)
        {
            _context.TblClientes.Remove(obj);
            await _context.SaveChangesAsync();

        }



    }
}