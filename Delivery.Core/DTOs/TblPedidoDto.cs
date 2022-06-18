using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.DTOs
{
    public class TblPedidoDto
    {
        public decimal IdPedido { get; set; }
        public decimal? IdCliente { get; set; }
        public decimal? IdProducto { get; set; }
        public string? Fecha { get; set; }
        public string? DireccionEntrega { get; set; }
        public decimal? IdEmpleado { get; set; }
        public decimal? Precio { get; set; }
        public decimal Iva { get; set; }
        public decimal? Total { get; set; }
    }
}
