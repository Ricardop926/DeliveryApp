using Delivery.Core.DTOs;
using Delivery.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Interfaces
{
    public interface ITblClienteRepository
    {
        Task<IEnumerable<TblCliente>> GetTblClientes();
        Task<TblCliente> GetTblCliente(int id);
        Task InsertTblCliente(TblCliente _tblCliente);
        Task UpdateTblCliente(TblCliente cliente);
    }
}
