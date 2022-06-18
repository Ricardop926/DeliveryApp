using Delivery.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Interfaces
{
    public interface ITblRestauranteRepository
    {
        Task<IEnumerable<TblRestaurante>> GetTblRestaurantes();
    }
}
