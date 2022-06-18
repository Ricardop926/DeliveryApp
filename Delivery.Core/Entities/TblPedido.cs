using System;
using System.Collections.Generic;

namespace Delivery.Core.Entities
{
    public partial class TblPedido
    {
        public TblPedido()
        {
            TblDetallepedidos = new HashSet<TblDetallepedido>();
        }

        public decimal IdPedido { get; set; }
        public decimal? IdCliente { get; set; }
        public decimal? IdProducto { get; set; }
        public string? Fecha { get; set; }
        public string? DireccionEntrega { get; set; }
        public decimal? IdEmpleado { get; set; }
        public decimal? Precio { get; set; }
        public decimal Iva { get; set; }
        public decimal? Total { get; set; }

        public virtual TblCliente? IdClienteNavigation { get; set; }
        public virtual TblProducto? IdProductoNavigation { get; set; }
        public virtual ICollection<TblDetallepedido> TblDetallepedidos { get; set; }
    }
}
