using Delivery.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Interfaces
{
    public interface ITblPedidoRepository
    {
        Task<IEnumerable<TblPedido>> GetTblPedidos();
        Task AddTblPedido(TblPedido obj);
    }
}
