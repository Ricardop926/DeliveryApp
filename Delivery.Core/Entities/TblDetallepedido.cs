using System;
using System.Collections.Generic;

namespace Delivery.Core.Entities
{
    public partial class TblDetallepedido
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

        public virtual TblEmpleado? IdEmpleadoNavigation { get; set; }
        public virtual TblPedido? IdPedidoNavigation { get; set; }
        public virtual TblRestaurante? IdRestauranteNavigation { get; set; }
        public object TblDetallepedidoId { get; set; }
    }
}
