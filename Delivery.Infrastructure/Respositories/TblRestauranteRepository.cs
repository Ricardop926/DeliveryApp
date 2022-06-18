using Delivery.Core.Entities;
using Delivery.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Respositories
{
    public class TblRestauranteRepository
    {
        private readonly DB_MafiaTechContext _context;

        public  TblRestauranteRepository(DB_MafiaTechContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TblRestaurante>> GetTblRestaurantes()
        {
            var _tblrestaurante = await _context.TblRestaurantes.ToListAsync();
            return _tblrestaurante;
        }
    }
}
