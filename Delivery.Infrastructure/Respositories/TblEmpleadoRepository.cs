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
    public class TblEmpleadoRepository : ITblEmpleadoRepository
    {
        private readonly DB_MafiaTechContext _context;

        public TblEmpleadoRepository(DB_MafiaTechContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblEmpleado>> GetTblEmpleados()
        {
            var _tblPedido = await _context.TblEmpleados.ToListAsync();
            return _tblPedido;
        }
    }
}
