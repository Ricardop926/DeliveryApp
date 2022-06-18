using System;
using System.Collections.Generic;

namespace Delivery.Core.Entities
{
    public partial class TblRestaurante
    {
        public TblRestaurante()
        {
            TblDetallepedidos = new HashSet<TblDetallepedido>();
        }

        public decimal IdRestaurante { get; set; }
        public string? NombreRestautante { get; set; }
        public string? DireccionRestaurante { get; set; }
        public string? EmailRestaurante { get; set; }

        public virtual ICollection<TblDetallepedido> TblDetallepedidos { get; set; }
    }
}
