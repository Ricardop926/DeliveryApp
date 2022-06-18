using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.DTOs
{
    public class TblRestauranteDto
    {
        public decimal IdRestaurante { get; set; }
        public string? NombreRestautante { get; set; }
        public string? DireccionRestaurante { get; set; }
        public string? EmailRestaurante { get; set; }

    }
}
