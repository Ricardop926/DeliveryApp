using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.DTOs
{
    public class TblEmpleadoDto
    {
        public decimal IdEmpleado { get; set; }
        public string? NombreEmpleado { get; set; }
        public decimal? FechaNcimiento { get; set; }
        public decimal? FechaIngreso { get; set; }
    }
}
