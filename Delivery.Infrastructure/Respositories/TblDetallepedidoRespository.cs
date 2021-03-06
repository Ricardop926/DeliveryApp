using Delivery.Core.Entities;
using Delivery.Core.Interfaces;
using Delivery.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Infrastructure.Respositories
{
    public class TblDetallepedidoRespository : ITblDetallepedidoRepository
    {
        private readonly DB_MafiaTechContext _context;

        public TblDetallepedidoRespository(DB_MafiaTechContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblDetallepedido>> GetTblDetallepedidos()
        {
            var _Detallepedido = await _context.TblDetallepedidos.ToListAsync();
            return _Detallepedido;
        }

        public async Task<TblDetallepedido> GetTblDetallepedido(int id)
        {
            var _Detallepedido = await _context.TblDetallepedidos.FirstOrDefaultAsync(x => x.IdDetallePedido == id);
            return _Detallepedido;

        }

        public async Task AddTblDetallepedido(TblDetallepedido _Detallepedido)
        {
            _context.TblDetallepedidos.Add(_Detallepedido);
            await _context.SaveChangesAsync();

        }

        public async Task InsertDetallepedido(TblDetallepedido _Detallepedido)
        {
            _context.TblDetallepedidos.Add(_Detallepedido);
            await _context.SaveChangesAsync();

        }

        public async Task<bool> UpdateTblDetallepedido(TblDetallepedido _Detallepedido)
        {
            var currentTbldetallepedido = await _context.TblDetallepedidos.FirstOrDefaultAsync(x => x.IdDetallePedido == _Detallepedido.IdDetallePedido);
            currentTbldetallepedido.NombreEmpleado = _Detallepedido.NombreEmpleado;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteTblDetallepedido(int id)
        {
            var currentTbldetallepedido = await GetTblDetallepedido(id); 
            _context.TblDetallepedidos.Remove(currentTbldetallepedido);
            int rows = await _context.SaveChangesAsync();
            return rows > 0;

        }



    }
}
