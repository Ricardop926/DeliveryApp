using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.DTOs
{
    public class TblClienteDto
    {
        public decimal IdCliente { get; set; }
        public decimal? Nombre { get; set; }
        public string? Email { get; set; }
        public string? FechaIngreso { get; set; }
    }
}
