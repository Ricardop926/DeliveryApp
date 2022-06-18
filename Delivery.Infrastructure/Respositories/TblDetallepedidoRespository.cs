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
            var _tblCliente = await _context.TblDetallepedidos.ToListAsync();
            return _tblCliente;
        }

        public async Task AddTblDetallepedido(TblDetallepedido obj)
        {
            _context.TblDetallepedidos.Add(obj);
            await _context.SaveChangesAsync();

        }
    }
}
