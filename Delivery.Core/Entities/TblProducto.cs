using System;
using System.Collections.Generic;

namespace Delivery.Core.Entities
{
    public partial class TblProducto
    {
        public TblProducto()
        {
            TblPedidos = new HashSet<TblPedido>();
        }

        public decimal IdProducto { get; set; }
        public string? NombreProducto { get; set; }
        public decimal? IdRestaurante { get; set; }
        public decimal? Precio { get; set; }

        public virtual ICollection<TblPedido> TblPedidos { get; set; }
    }
}
