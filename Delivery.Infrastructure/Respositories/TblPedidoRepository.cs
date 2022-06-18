using Delivery.Core.Entities;
using Delivery.Core.Interfaces;
using Delivery.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Respositories
{
    public class TblPedidoRepository : ITblPedidoRepository
    {
        private readonly DB_MafiaTechContext _context;

        public TblPedidoRepository(DB_MafiaTechContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblPedido>> GetTblPedidos()
        {
            var _tblPedido = await _context.TblPedidos.ToListAsync();
            return _tblPedido;
        }
        public async Task AddTblPedido(TblPedido obj)
        {
            _context.TblPedidos.Add(obj);
            await _context.SaveChangesAsync();

        }
    }
}
