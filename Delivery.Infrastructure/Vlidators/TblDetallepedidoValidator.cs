using Delivery.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Vlidators
{
    public class TblDetallepedidoValidator : AbstractValidator<TblDetallepedidoDto>
    {
        public TblDetallepedidoValidator()
        {
            RuleFor(tblDetallepedido => tblDetallepedido.IdDetallePedido)
                .NotNull();
                

           

        }
    }
}
