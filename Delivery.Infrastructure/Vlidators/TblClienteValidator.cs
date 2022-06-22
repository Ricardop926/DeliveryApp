using Delivery.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Vlidators
{
    public class TblClienteValidator : AbstractValidator<TblClienteDto>
    {
        public TblClienteValidator()
        {
            RuleFor(tblCliente => tblCliente.Email)
                .NotNull()
                .Length(1, 20);

            RuleFor(tblCliente => tblCliente.Nombre)
               .NotNull();
               
        }

        
    }
}
