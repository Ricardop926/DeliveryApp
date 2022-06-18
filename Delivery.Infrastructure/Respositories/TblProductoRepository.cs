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
    public class TblProductoRepository : ITblProductoRepository
    {
        private readonly DB_MafiaTechContext _context;

        public TblProductoRepository(DB_MafiaTechContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblProducto>> GetTblProductos()
        {
            var _tblProducto = await _context.TblProductos.ToListAsync();
            return _tblProducto;
        }

    }
}
