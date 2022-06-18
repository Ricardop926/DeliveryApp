using System;
using System.Collections.Generic;

namespace Delivery.Core.Entities
{
    public partial class TblEmpleado
    {
        public TblEmpleado()
        {
            TblDetallepedidos = new HashSet<TblDetallepedido>();
        }

        public decimal IdEmpleado { get; set; }
        public string? NombreEmpleado { get; set; }
        public decimal? FechaNcimiento { get; set; }
        public decimal? FechaIngreso { get; set; }

        public virtual ICollection<TblDetallepedido> TblDetallepedidos { get; set; }
    }
}
