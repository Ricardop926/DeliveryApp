using System;
using System.Collections.Generic;

namespace Delivery.Core.Entities
{
    public partial class TblCliente
    {
        public TblCliente()
        {
            TblPedidos = new HashSet<TblPedido>();
        }

        public decimal IdCliente { get; set; }
        public decimal? Nombre { get; set; }
        public string? Email { get; set; }
        public string? FechaIngreso { get; set; }

        public virtual ICollection<TblPedido> TblPedidos { get; set; }

        
    }
}
