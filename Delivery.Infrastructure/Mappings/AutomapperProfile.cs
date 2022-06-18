using AutoMapper;
using Delivery.Core.DTOs;
using Delivery.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Infrastructure.Mappings
{
    public class Automapper_Profile : Profile
    {
        public Automapper_Profile()
        {
            CreateMap<TblCliente, TblClienteDto>();
            CreateMap<TblClienteDto, TblCliente>();

            CreateMap < TblDetallepedido, TblDetallepedidoDto > ();
            CreateMap<TblDetallepedidoDto, TblDetallepedido>();

            CreateMap<TblEmpleado, TblEmpleadoDto>();
            CreateMap<TblEmpleadoDto, TblEmpleado>();


            CreateMap<TblPedido, TblPedidoDto>();
            CreateMap<TblPedidoDto, TblPedido>();

            CreateMap<TblProducto, TblProductoDto>();
            CreateMap<TblProductoDto, TblProducto>();

            CreateMap<TblRestaurante, TblRestauranteDto>();
            CreateMap<TblRestauranteDto, TblRestaurante>();



        }
    }
}
