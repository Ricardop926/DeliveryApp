using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.DTOs
{
    public class TblProductoDto
    {
        public decimal IdProducto { get; set; }
        public string? NombreProducto { get; set; }
        public decimal? IdRestaurante { get; set; }
        public decimal? Precio { get; set; }
    }
}
