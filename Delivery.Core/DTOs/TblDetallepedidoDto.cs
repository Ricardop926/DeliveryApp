using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.DTOs
{
    public class TblDetallepedidoDto
    {
        public decimal IdDetallePedido { get; set; }
        public decimal? IdPedido { get; set; }
        public decimal? IdProducto { get; set; }
        public decimal? IdEmpleado { get; set; }
        public decimal? IdRestaurante { get; set; }
        public string? NombreRestautante { get; set; }
        public string? NombreEmpleado { get; set; }
        public decimal? PrecioUnidad { get; set; }
        public decimal? Cantidad { get; set; }

    }
}
